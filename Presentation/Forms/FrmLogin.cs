using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using FitnessTracker.Desktop.Util;
using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Forms;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Identity;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Presentation.Forms;
using System.Text.RegularExpressions;

namespace FitnessTracker.Desktop
{
    public partial class FrmLogin : Form
    {
        private int _failCount = 0;
        private readonly int _failAttemptLimit = 5;
        private readonly UserUseCase _userUseCase;
       
        public FrmLogin(UserUseCase userUseCase)
        {
            _userUseCase = userUseCase;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                CustomMessageBoxUtil.Warning("Please enter user name.");
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                CustomMessageBoxUtil.Warning("Please enter password.");
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private void TryLogin()
        {
            if (!IsValid()) return;
            var result = _userUseCase.Login(txtUserName.Text, txtPassword.Text);
            if (!result.Success)
            {
                _failCount++;
                var message = $"{result.Message} \n Fail attempt {_failCount}. \n App will be close after {_failAttemptLimit - _failCount}";
                CustomMessageBoxUtil.Error(message); return;
            }
            if (IsLoginAttemptExceedHandle()) return;
            UserIdentity.Instance.Init(result.Data);
            CheckUserProfile(result.Data);
            ShowDashBoard(result.Data);
        }

        private void ShowDashBoard(UserDetail user)
        {
            var role = user.Role.RoleName;
            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                CommonUtil.ShowForm(App.MyServiceProvider.GetService<FrmAdminDashBoard>());
            else
                CommonUtil.ShowForm(App.MyServiceProvider.GetService<FrmUserHome>());

            this.Hide();
        }

        private void CheckUserProfile(UserDetail userDetail)
        {
            var profile = userDetail.Profile;
            if (profile is null && userDetail.Role.RoleName.Equals("User"))
            {
                CommonUtil.ShowDialogForm(App.MyServiceProvider.GetService<FrmUserProfile>());
            }
        }

        private bool IsLoginAttemptExceedHandle()
        {
            if (_failCount > _failAttemptLimit)
            {
                Application.Exit();
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e) => TryLogin();

        private void lblDontHaveAcount_Click(object sender, EventArgs e) => CommonUtil.ShowDialogForm(App.MyServiceProvider.GetService<FrmUserRegister>());

        private void label5_Click(object sender, EventArgs e)
        {
            var frm = App.MyServiceProvider.GetService<FrmUserRegister>();
            frm.FormMode = "Admin";
            CommonUtil.ShowDialogForm(frm);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
#if DEBUG
            txtUserName.Text = "user1";
            txtPassword.Text = "Aa1234567";
#endif
        }
    }
}
