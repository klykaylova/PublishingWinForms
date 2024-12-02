using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult dialogResult = MessageBox.Show("Оберіть тип входу(так - адміністратор, ні - користувач)", "Вхід", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Run(new AdminPage());
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Run(new UserPage());
            }
        }
    }
}
