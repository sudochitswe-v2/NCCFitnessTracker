using System;
using FitnessTracker.Desktop.Identity;
using System.Windows.Forms;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Util;
using static FitnessTracker.Desktop.Constant;
using FitnessTracker.Desktop.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Desktop.Forms
{
    public partial class FrmUserDashBorad : Form
    {
        private IEnumerable<Goal> Goals { get; set; }
        private readonly TrackingUseCase _trackingUseCase;
        private readonly ActivityUseCase _activityUseCase;
        public FrmUserDashBorad(TrackingUseCase tackingUseCase, ActivityUseCase activityUseCase)
        {
            _trackingUseCase = tackingUseCase;
            _activityUseCase = activityUseCase;
            InitializeComponent();
        }

        private void FrmDashBorad_Load(object sender, EventArgs e)
        {
            var user = UserIdentity.Instance;
            this.txtWelcome.Text = $"Welcome ! {user.Name} ";
            this.txtUserWeight.Text = user.UserProfile.Weight.ToString();
        }
        #region Goal Related
        private void LoadGoals(bool reqiredRefresh = false)
        {
            var user = UserIdentity.Instance.Id;
            this.Goals = _trackingUseCase.GetGoals(user);
            dgvGoals.DataSource = this.Goals;
            if (reqiredRefresh) dgvGoals.Refresh();
        }
        private void SaveGoal()
        {
            var user = UserIdentity.Instance;
            var calories = GetTargetCalories();
            if (calories is 0) return;
            var goal = new Goal
            {
                ID = Guid.NewGuid(),
                UserID = user.Id,
                Name = txtGoalName.Text,
                TargetCalories = calories,
                Status = GoalStatus.INPROGRESS,
                CreatedBy = user.Name,
                CreatedOn = DateTime.Now,
                ModifiedBy = user.Name,
                ModifiedOn = DateTime.Now,
            };
            var result = _trackingUseCase.SaveGoal(goal);
            if (result.Success)
            {
                CustomMessageBoxUtil.Information(AppMessage.SAVE_SUCCES);
                txtTargetCalories.Clear();
                LoadGoals(true);
            }
            else
                CustomMessageBoxUtil.Error(AppMessage.ERROR_WHILE_SAVING);
        }
        private int GetTargetCalories()
        {
            var calories = Convert.ToInt32(txtTargetCalories.Text);
            if (calories is 0)
            {
                CustomMessageBoxUtil.Error(AppMessage.GOAL_CANT_BE_ZERO);
            }
            return calories;
        }
        #endregion

        #region Activity Related
        private void LoadActivities()
        {
            var activities = _activityUseCase.GetAllActivities();
            cboActivities.DisplayMember = nameof(Activity.Name);
            cboActivities.ValueMember = nameof(Activity.ID);
            cboActivities.DataSource = activities;

        }
        private void ActivitiesChange()
        {
            var activities = cboActivities.DataSource as IEnumerable<Activity>;
            var selectedId = cboActivities.SelectedValue;
            var selectedAct = activities.First(a => a.ID.Equals(selectedId));
            lblMetric1.Text = selectedAct.Metric1;
            lblMetric2.Text = selectedAct.Metric2;
            lblMetric3.Text = selectedAct.Metric3;
        }

        #endregion

        #region Tracking Related
        private void LoadTrackingResult(bool requiredRefresh = false)
        {
            var user = UserIdentity.Instance.Id;
            var result = _trackingUseCase.GetTrackingData(user);
            dgvTrackings.DataSource = result;
            if (requiredRefresh) dgvTrackings.Refresh();
        }
        private bool IsValidated()
        {
            if (string.IsNullOrEmpty(txtMet.Text)) return false;
            if (string.IsNullOrEmpty(txtUserWeight.Text)) return false;
            if (string.IsNullOrEmpty(txtMetric1.Text)) return false;
            if (string.IsNullOrEmpty(txtMetric2.Text)) return false;
            if (string.IsNullOrEmpty(txtMetric3.Text)) return false;
            return true;
        }
        private void CalculateBurnedCalories()
        {
            if (!IsValidated()) return;
            var met = Convert.ToDecimal(txtMet.Text);
            var weight = Convert.ToInt32(txtUserWeight.Text);
            var hours = Convert.ToInt32(txtMetric3.Text);
            var burnedCalories = met * weight * hours;
            txtBurnedCalories.Text = burnedCalories.ToString();
        }
        private void BurnedCaloriesTextChange()
        {
            if (string.IsNullOrEmpty(txtBurnedCalories.Text))
            {
                btnSaveTracking.Enabled = false;
            }
            else
            {
                btnSaveTracking.Enabled = true;
            }
        }
        private void TrackingTabLoad()
        {
            LoadGoals();
            LoadActivities();
            LoadTrackingResult();
            cboTargetGoal.DataSource = new List<Goal>(this.Goals.Where(g => g.Status.Equals(GoalStatus.INPROGRESS)));
            cboTargetGoal.DisplayMember = nameof(Goal.TargetCalories);
            cboTargetGoal.ValueMember = nameof(Goal.ID);
        }

        private void SaveTracking()
        {
            var user = UserIdentity.Instance;
            var data = new ActivityTracking
            {
                ID = Guid.NewGuid(),
                GoalID = Guid.Parse(cboTargetGoal.SelectedValue.ToString()),
                ActivityID = Guid.Parse(cboActivities.SelectedValue.ToString()),
                BurnedCalories = Convert.ToInt32(txtBurnedCalories.Text),
                Metric1Value = Convert.ToInt32(txtMetric1.Text),
                Metric2Value = Convert.ToInt32(txtMetric2.Text),
                Metric3Value = Convert.ToInt32(txtMetric3.Text),
                CreatedBy = user.Name,
                ModifiedBy = user.Name,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now
            };
            var result = _trackingUseCase.SaveTracking(data);
            if (result.Success)
            {
                UpdateGoalStatusIfComplete();
                CustomMessageBoxUtil.Information(AppMessage.SAVE_SUCCES);
                LoadTrackingResult(true);
                ClearTrackingRelateTextBox();
            }
            else
            {
                CustomMessageBoxUtil.Error(AppMessage.ERROR_WHILE_SAVING);
            }
        }
        private void UpdateGoalStatusIfComplete()
        {
            var goalId = Guid.Parse(cboTargetGoal.SelectedValue.ToString());
            var burnCal = Convert.ToInt32(txtBurnedCalories.Text);
            var targetCal = Convert.ToInt32(cboTargetGoal.Text);
            if (burnCal >= targetCal)
            {
                _trackingUseCase.UpdateGoalStatus(goalId, GoalStatus.COMPLETE);
            }
        }
        private void ClearTrackingRelateTextBox()
        {
            txtMetric1.Clear();
            txtMetric2.Clear();
            txtMetric3.Clear();
            txtMet.Clear();
            txtBurnedCalories.Clear();
        }
        #endregion
        private void HandleTabChange()
        {
            if (tabMainPage.SelectedIndex == 1)
            {
                LoadGoals();
            }
            if (tabMainPage.SelectedIndex == 2)
            {
                TrackingTabLoad();
            }
        }
        private void tabMainPage_SelectedIndexChanged(object sender, EventArgs e) => HandleTabChange();

        private void btnSave_Click(object sender, EventArgs e) => SaveGoal();

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) => ActivitiesChange();

        private void btnCalculate_Click(object sender, EventArgs e) => CalculateBurnedCalories();

        private void txtBurnedCalories_TextChanged(object sender, EventArgs e) => BurnedCaloriesTextChange();

        private void btnSaveTracking_Click(object sender, EventArgs e) => SaveTracking();
    }
}
