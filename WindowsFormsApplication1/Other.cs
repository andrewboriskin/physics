using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Other
    {
        public bool exit()
        {
            DialogResult result;
            result = MessageBox.Show("Вы точно хотите закрыть программу?", "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
