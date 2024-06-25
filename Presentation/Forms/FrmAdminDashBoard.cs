using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Identity;
using FitnessTracker.Desktop.Util;
using System;
using System.Windows.Forms;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Presentation.Forms
{
    public partial class FrmAdminDashBoard : Form
    {
        private readonly ActivityUseCase _activityUseCase;
        private FormMode formMode = FormMode.NEW;
        private Activity selectedActivity;
        public FrmAdminDashBoard(ActivityUseCase activityUseCase)
        {
            _activityUseCase = activityUseCase;
            InitializeComponent();
        }
        private void LoadForm()
        {
            var user = UserIdentity.Instance;
            this.txtWelcome.Text = $"Welcome ! {user.Name} ";
        }
        private void ChangeSaveButtonLabel()
        {
            if (formMode == FormMode.NEW)
                btnSave.Text = "Save";
            else
                btnSave.Text = "Edit";
        }
        private void LoadActivities(bool isRefresh = false)
        {
            var activities = _activityUseCase.GetAllActivities();
            dgvActivity.DataSource = activities;
            if (isRefresh) dgvActivity.Refresh();
        }
        private void SaveActivity()
        {
            Result<dynamic> result;
            if (formMode == FormMode.NEW)
                result = _activityUseCase.SaveActivity(CreateNew());
            else
                result = _activityUseCase.SaveActivity(Edit());

            if (result.Success)
            {
                CustomMessageBoxUtil.Information(result.Message);
                LoadActivities(true);
                CancelEdit();
            }
            else
                CustomMessageBoxUtil.Error(result.Message);
        }
        private Activity CreateNew()
        {
            var user = UserIdentity.Instance.Name;
            return new Activity
            {
                ID = Guid.NewGuid(),
                Name = txtName.Text,
                Metric1 = txtMetric1.Text,
                Metric2 = txtMetric2.Text,
                Metric3 = txtMetric3.Text,
                CreatedBy = user,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedBy = user,
            };
        }
        private Activity Edit()
        {
            var user = UserIdentity.Instance.Name;
            return new Activity
            {
                ID = selectedActivity.ID,
                Name = txtName.Text,
                Metric1 = txtMetric1.Text,
                Metric2 = txtMetric2.Text,
                Metric3 = txtMetric3.Text,
                CreatedBy = selectedActivity.CreatedBy,
                CreatedOn = selectedActivity.CreatedOn,
                ModifiedOn = DateTime.Now,
                ModifiedBy = user,
            };
        }
        private void HandleTabChanged()
        {
            // Tab index 2 is Activity Tab
            if (tabMainPage.SelectedIndex == 2)
            {
                LoadActivities();
            }
        }

        private void HandleCellClick()
        {
            var current = dgvActivity.CurrentRow.DataBoundItem as Activity;
            if (current == null) return;
            selectedActivity = current;
            BindEditData();
        }
        private void BindEditData()
        {
            this.formMode = FormMode.EDIT;
            ChangeSaveButtonLabel();
            txtName.Text = selectedActivity.Name;
            txtMetric1.Text = selectedActivity.Metric1;
            txtMetric2.Text = selectedActivity.Metric2;
            txtMetric3.Text = selectedActivity.Metric3;
        }
        private void CancelEdit()
        {
            formMode = FormMode.NEW;
            ChangeSaveButtonLabel();
            selectedActivity = null;
            ClearAllTextBox();
        }
        private void ClearAllTextBox()
        {
            txtName?.Clear();
            txtMetric1.Clear();
            txtMetric2?.Clear();
            txtMetric3?.Clear();
        }
        private void DeleteActivity()
        {
            var result = _activityUseCase.DeleteActitiy(Edit());
            if (result.Success)
            {
                CustomMessageBoxUtil.Information(result.Message);
                LoadActivities();
            }
            else
                CustomMessageBoxUtil.Error(result.Message);
        }
        private void FrmAdminDashBoard_Load(object sender, EventArgs e) => LoadForm();

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e) => HandleCellClick();

        private void btnCancel_Click(object sender, EventArgs e) => CancelEdit();

        private void btnSave_Click(object sender, EventArgs e) => SaveActivity();

        private void tabMainPage_SelectedIndexChanged(object sender, EventArgs e) => HandleTabChanged();

        private void btnDelete_Click(object sender, EventArgs e) => DeleteActivity();
    }
}
