using FitnessTracker.Desktop.Data.Context.DataSetFitnessTrackerTableAdapters;
using FitnessTracker.Desktop.Util;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Forms;
using FitnessTracker.Desktop.Domain.Models;
using FitnessTracker.Desktop.Identity;

namespace FitnessTracker.Desktop
{
    public partial class FrmLogin : Form
    {
        private readonly tb_SystemUserTableAdapter _userAdapter;
        private int _failCount = 0;
        private readonly int _failAttemptLimit = 5;
        public FrmLogin(tb_SystemUserTableAdapter userAdapter)
        {
            _userAdapter = userAdapter;
            InitializeComponent();
        }
        private void TryLogin()
        {
            var dt = _userAdapter.GetUserByEmail(txtEmail.Text);
            if (dt.Rows.Count is 0)
            {
                _failCount++;
                var message = $"{Constant.Message.INVALID_USER_ID} \n Fail attempt {_failCount}. \n App will be close after {_failAttemptLimit - _failCount}";
                CustomMessageBoxUtil.Error(message); return;
            }
            var user = CommonUtil.ConvertDataRowToObject<User>(dt.Rows[0]);
            if (!txtPassword.Text.Equals(user.Password))
            {
                _failCount++;
                var message = $"{Constant.Message.INVALID_USER_ID} \n Fail attempt {_failCount}. \n App will be close after {_failAttemptLimit - _failCount}";
                CustomMessageBoxUtil.Error(message); return;
            }
            if (IsLoginAttemptExceedHandle()) return;
            UserIdentity.Instance.Init(user);
            var dashBorad = App.MyServiceProvider.GetService<FrmDashBorad>();
            CommonUtil.ShowForm(dashBorad);
            dashBorad.Activate();
            this.Hide();
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
    }
}
