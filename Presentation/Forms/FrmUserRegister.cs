using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Util;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Forms
{
    public partial class FrmUserRegister : Form
    {
        public string FormMode { get; set; } = "User";
        private readonly UserUseCase _userUseCase;
        private Guid roleId;
        public FrmUserRegister(UserUseCase userUseCase)
        {
            _userUseCase = userUseCase;
            InitializeComponent();
        }

        private void GenerateID()
        {
            this.Text = $"Register as {this.FormMode}";
            var userRole = _userUseCase.GetRoles().First(role => role.RoleName.Equals(FormMode, StringComparison.OrdinalIgnoreCase));
            roleId = userRole.ID;
        }
        private bool CheckIsUserNameValid()
        {
            Regex regex = new Regex(@"[~`!@#$%^&*()_\-+=\[\]{}|\\;:'"",.<>?/]");
            if (regex.IsMatch(txtEmail.Text))
            {
                CustomMessageBoxUtil.Error("User name can only contain number and letter");
                return false;
            }
            return true;
        }
        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                CustomMessageBoxUtil.Error("Please fill Full Name");
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                CustomMessageBoxUtil.Error("Please fill User Name");
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
            if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                txtPassword.Focus();
                CustomMessageBoxUtil.Error("Password and confrim password doesn't match.");
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
            if (password.Length != 12)
            {
                CustomMessageBoxUtil.Error("Password must be length of 12 characters ");
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private void Register()
        {
            if (!IsDataValid()) return;
            if (!CheckIsUserNameValid()) return;
            var user = new User
            {
                ID = Guid.NewGuid(),
                FullName = txtUserName.Text,
                RoleID = roleId,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                CreatedBy = txtUserName.Text,
                CreatedOn = DateTime.Now,
                ModifiedBy = txtUserName.Text,
                ModifiedOn = DateTime.Now
            };
            var result = _userUseCase.Register(user);
            if (result.Success)
            {
                CustomMessageBoxUtil.Information(result.Message);
                this.Close();
            }
            else
            {
                CustomMessageBoxUtil.Warning(result.Message);
            }
        }
        private void FrmUserRegister_Load(object sender, EventArgs e) => GenerateID();

        private void btnRegister_Click(object sender, EventArgs e) => Register();


    }
}
