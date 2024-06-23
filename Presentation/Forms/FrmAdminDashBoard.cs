using FitnessTracker.Desktop.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.Desktop.Presentation.Forms
{
    public partial class FrmAdminDashBoard : Form
    {
        public FrmAdminDashBoard()
        {
            InitializeComponent();
        }

        private void FrmAdminDashBoard_Load(object sender, EventArgs e)
        {
            var user = UserIdentity.Instance;
            this.txtWelcome.Text = $"Welcome ! {user.Name} ";
        }
    }
}
