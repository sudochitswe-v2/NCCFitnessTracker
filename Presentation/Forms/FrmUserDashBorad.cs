using System;
using FitnessTracker.Desktop.Identity;
using System.Windows.Forms;

namespace FitnessTracker.Desktop.Forms
{
    public partial class FrmUserDashBorad : Form
    {
        public FrmUserDashBorad()
        {
            InitializeComponent();
        }

        private void FrmDashBorad_Load(object sender, EventArgs e)
        {
            var user = UserIdentity.Instance;
            this.txtWelcome.Text = $"Welcome ! {user.Name} ";
        }
    }
}
