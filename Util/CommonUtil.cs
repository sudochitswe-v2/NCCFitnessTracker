using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.Desktop.Common
{
    public static class CommonUtil
    {
        public static void ShowForm(Form form) => form.Show();
        public static void ShowDialogForm(Form form) => form.ShowDialog();

    }
}
