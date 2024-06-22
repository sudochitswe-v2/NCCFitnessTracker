using System;
using System.Linq;
using System.Windows.Forms;
using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Data.Context.DataSetFitnessTrackerTableAdapters;
using FitnessTracker.Desktop.Domain.Models;
using FitnessTracker.Desktop.Util;

namespace FitnessTracker.Desktop.Forms
{
    public partial class FrmUserRegister : Form
    {
        private readonly tb_SystemUserTableAdapter _tb_UserAdapter;
        public FrmUserRegister(tb_SystemUserTableAdapter tb_UserAdapter)
        {
            _tb_UserAdapter = tb_UserAdapter;
            InitializeComponent();
        }

        private void GenerateID()
        {
            var lastID = _tb_UserAdapter.GetLastID();
            if (lastID is null)
            {
                var Id = FormatUtil.IntToLeadingZeroString(1, 3, Constant.IdentityPrefix.USER);
                txtUserID.Text = Id;
            }
            else
            {
                var newID = int.Parse(lastID.Substring(1));
                txtUserID.Text = FormatUtil.IntToLeadingZeroString(newID + 1, 3, Constant.IdentityPrefix.USER);
            }
        }
        private void ClearInput()
        {
            txtUserID.Text =
            txtUserName.Text = txtEmail.Text =
            txtEmail.Text = txtPassword.Text =
            txtConfirmPassword.Text =
            string.Empty;
        }
        private void Register()
        {
            if (!IsDataValid()) return;
            var user = new User
            {
                UserID = txtUserID.Text,
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                CreatedBy = txtUserID.Text,
                CreatedOn = DateTime.Now,
                ModifiedBy = txtUserID.Text,
                ModifiedOn = DateTime.Now
            };
            var row = _tb_UserAdapter.Insert(
                       user.UserID,
                       user.UserName,
                       user.Email,
                       user.Password,
                       user.CreatedBy,
                       user.CreatedOn,
                       user.ModifiedBy,
                       user.ModifiedOn
                );
            if (row > 0)
            {
                CustomMessageBoxUtil.Information("Staff registration success");
                this.Close();
            }
            else
            {
                CustomMessageBoxUtil.Warning("Staff registration doesn't complete");
            }
        }
        private void FrmUserRegister_Load(object sender, EventArgs e) => GenerateID();
        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                CustomMessageBoxUtil.Error("Please fill User Name");
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                CustomMessageBoxUtil.Error("Please fill Email Address");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                CustomMessageBoxUtil.Error("Please fill Password");
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                CustomMessageBoxUtil.Error("Please fill Confirm Password");
                return false;
            }
            var password = txtPassword.Text;
            if (!password.Any(char.IsUpper))
            {

                CustomMessageBoxUtil.Error("Password should include at least one upper character.");
                txtPassword.Focus();
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                CustomMessageBoxUtil.Error("Password should include at least one lower character.");
                txtPassword.Focus();
                return false;
            }
            if (!(password.Length >= 8 && password.Length < 16))
            {
                CustomMessageBoxUtil.Error("Password must be between 8 to 16 characters ");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e) => Register();
    }
}
