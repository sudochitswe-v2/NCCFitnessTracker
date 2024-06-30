using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Identity;
using FitnessTracker.Desktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Presentation.Forms
{
    public partial class FrmUserGoalActivities : Form
    {
        public Goal SelectedGoal { get; set; }
        private readonly TrackingUseCase _trackingUseCase;
        private readonly ActivityUseCase _activityUseCase;
        public FrmUserGoalActivities(TrackingUseCase trackingUseCase, ActivityUseCase activityUseCase)
        {
            _trackingUseCase = trackingUseCase;
            _activityUseCase = activityUseCase;
            InitializeComponent();
        }
        private void LoadFormData()
        {
            var user = UserIdentity.Instance.UserProfile;
            txtUserWeight.Text = user.Weight.ToString();
            BindGoalData();
            LoadActivities();
            LoadGoalActivities();
        }
        private void RefreshGoalComplete()
        {
            lblStatusValue.Text = GoalStatus.COMPLETE;
        }
        private void LoadGoalActivities(bool requiredRefresh = false)
        {
            var user = UserIdentity.Instance.Id;
            var result = _trackingUseCase.GetTrackingData(user, SelectedGoal.ID);
            dgvTrackings.DataSource = result;
            if (requiredRefresh) dgvTrackings.Refresh();
        }
        private void BindGoalData()
        {
            gpbGoal.Text = SelectedGoal.Name;
            txtTargetCalories.Text = SelectedGoal.TargetCalories.ToString();
            lblStatusValue.Text = SelectedGoal.Status;
        }
        private void LoadActivities()
        {
            var activities = _activityUseCase.GetAllActivities();
            cboActivities.DisplayMember = nameof(Activity.Name);
            cboActivities.ValueMember = nameof(Activity.ID);
            cboActivities.DataSource = activities;

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

        private void SaveTracking()
        {
            var user = UserIdentity.Instance;
            var data = new ActivityTracking
            {
                ID = Guid.NewGuid(),
                GoalID = this.SelectedGoal.ID,
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
                LoadGoalActivities(true);
                ClearTrackingRelateTextBox();
                RefreshGoalComplete();
            }
            else
            {
                CustomMessageBoxUtil.Error(AppMessage.ERROR_WHILE_SAVING);
            }
        }
        private void UpdateGoalStatusIfComplete()
        {
            var goalId = SelectedGoal.ID;
            var burnCal = Convert.ToInt32(txtBurnedCalories.Text);
            var targetCal = Convert.ToInt32(txtTargetCalories.Text);
            if (burnCal >= targetCal)
            {
                CustomMessageBoxUtil.Information(AppMessage.CONGRATULATIONS);
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
        private void ActivitiesChange()
        {
            var activities = cboActivities.DataSource as IEnumerable<Activity>;
            var selectedId = cboActivities.SelectedValue;
            var selectedAct = activities.First(a => a.ID.Equals(selectedId));
            lblMetric1.Text = selectedAct.Metric1;
            lblMetric2.Text = selectedAct.Metric2;
            lblMetric3.Text = selectedAct.Metric3;
        }
        private void FrmUserGoalActivities_Load(object sender, EventArgs e) => LoadFormData();

        private void btnCalculate_Click(object sender, EventArgs e) => CalculateBurnedCalories();

        private void btnSaveTracking_Click(object sender, EventArgs e) => SaveTracking();

        private void txtBurnedCalories_TextChanged(object sender, EventArgs e) => BurnedCaloriesTextChange();

        private void lblStatusValue_TextChanged(object sender, EventArgs e)
        {
            var value = lblStatusValue.Text;
            if (value.Equals(GoalStatus.COMPLETE))
            {
                lblStatusValue.ForeColor = Color.Green;
            }
            else
            {
                lblStatusValue.ForeColor = Color.Blue;
            }
            gbCalculation.Enabled = value.Equals(GoalStatus.INPROGRESS);
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) => ActivitiesChange();
    }
}
