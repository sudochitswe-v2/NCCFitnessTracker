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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Presentation.Forms
{
    public partial class FrmUserProfile : Form
    {
        private readonly UserUseCase _userUseCase;
        public FormMode FormMode { get; set; } = FormMode.NEW;
        public FrmUserProfile(UserUseCase userUseCase)
        {
            _userUseCase = userUseCase;
            this.MaximizeBox = false;
            this.ControlBox = false;
            InitializeComponent();
        }
        private void BindDataToControl(UserProfile profile)
        {
            txtHeight.Text = profile.Height.ToString();
            txtWeight.Text = profile.Weight.ToString();
            dtpDateOfBirth.Value = profile.DateOfBirth;
            BindGender(profile.Gender);
        }
        private void BindGender(string gender)
        {
            if (gender.Equals("Male")) rdoMale.Checked = true;
            if (gender.Equals("Female")) rdoFemale.Checked = true;
            if (gender.Equals("Other")) rdoOther.Checked = true;
        }
        private void LoadProfile()
        {

            if (this.FormMode == FormMode.EDIT)
            {
                lblAlertNewProfile.Visible = false;
                var profile = _userUseCase.GetUserProfile(UserIdentity.Instance.Id);
                BindDataToControl(profile);
            }
        }
        private string GetGender()
        {
            if (rdoMale.Checked) return rdoMale.Text;
            if (rdoFemale.Checked) return rdoFemale.Text;
            if (rdoOther.Checked) return rdoOther.Text;
            return string.Empty;
        }
        private UserProfile CreateProfile()
        {
            var id = UserIdentity.Instance.Id;
            var name = UserIdentity.Instance.Name;
            return new UserProfile()
            {
                UserID = id,
                Weight = Convert.ToInt32(txtWeight.Text),
                Height = Convert.ToInt32(txtHeight.Text),
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = GetGender(),
                CreatedBy = name,
                CreatedOn = DateTime.Now,
                ModifiedBy = name,
                ModifiedOn = DateTime.Now,
            };
        }
        private void SaveProfile()
        {
            var data = CreateProfile();
            var result = _userUseCase.SaveProfile(data);
            if (result.Success)
            {
                CustomMessageBoxUtil.Information(result.Message);
                this.Close();
            }
            else CustomMessageBoxUtil.Error(result.Message);
        }
        private void FrmUserProfile_Load(object sender, EventArgs e) => LoadProfile();

        private void btnLogin_Click(object sender, EventArgs e) => SaveProfile();
    }
}
