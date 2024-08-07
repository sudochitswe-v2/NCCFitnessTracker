using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Identity;
using FitnessTracker.Desktop.Util;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Presentation.Forms
{
    public partial class FrmUserHome : Form
    {
        private IEnumerable<Goal> Goals { get; set; }
        private readonly TrackingUseCase _trackingUseCase;
        private void LoadGoals(bool reqiredRefresh = false)
        {
            var user = UserIdentity.Instance.Id;
            this.Goals = _trackingUseCase.GetGoals(user);
            dgvGoals.DataSource = this.Goals;
            if (reqiredRefresh) dgvGoals.Refresh();
        }
        public FrmUserHome(TrackingUseCase tackingUseCase)
        {
            _trackingUseCase = tackingUseCase;
            InitializeComponent();
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
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtGoalName.Text))
            {
                CustomMessageBoxUtil.Error("Goal name can't be empty.");
                txtGoalName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTargetCalories.Text))
            {
                CustomMessageBoxUtil.Error("Target Calories can't be empty.");
                txtTargetCalories.Focus();
                return false;
            }
            return true;
        }
        private void SaveGoal()
        {
            if (!IsValid()) return;
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
        private void FrmUserHome_Load(object sender, EventArgs e)
        {
            var user = UserIdentity.Instance;
            this.txtWelcome.Text = $"Welcome ! {user.Name} ";
            LoadGoals();
        }
        private void HandleCellDoubleClick()
        {
            var goal = dgvGoals.CurrentRow.DataBoundItem as Goal;
            if (goal is null) return;
            var frm = App.MyServiceProvider.GetService<FrmUserGoalActivities>();
            frm.FormClosing += Frm_FormClosing;
            frm.SelectedGoal = goal;
            frm.ShowDialog();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e) => LoadGoals(true);

        private void LogOut()
        {
            var loginForm = App.MyServiceProvider.GetService<FrmLogin>();

            loginForm.Show();
            UserIdentity.Instance.Reset();
            this.Close();
        }
        private void PaintCompleteRow()
        {
            foreach (DataGridViewRow row in dgvGoals.Rows)
            {
                if (row.Cells[nameof(Goal.Status)].Value.Equals(Constant.GoalStatus.COMPLETE))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e) => SaveGoal();

        private void dgvGoals_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => HandleCellDoubleClick();

        private void toolStripMenuItem1_Click(object sender, EventArgs e) => LogOut();

        private void toolStripMenuItem2_Click(object sender, EventArgs e) => Application.Exit();

        private void dgvGoals_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) => PaintCompleteRow();
    }
}
