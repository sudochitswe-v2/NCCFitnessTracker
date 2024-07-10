
using System.Windows.Forms;

namespace FitnessTracker.Desktop.Common
{
    public static class CommonUtil
    {
        public static void ShowForm(Form form)
        {
            form.Show();
            form.Activate();
        }
        public static void ShowDialogForm(Form form) => form.ShowDialog();

    }
}
