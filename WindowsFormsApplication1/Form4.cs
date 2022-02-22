using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Visible = true;
            this.Visible = false;
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Other closed = new Other();
            if (closed.exit() == false)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            try
            {
                string pashalka = listBox1.SelectedItem.ToString();
                this.Visible = false;
                string path = Application.StartupPath + @"\htmls\" + pashalka + ".html";
                f5.Visible = true;
                f5.webBrowser1.Navigate(path);
            }
            catch
            {
                MessageBox.Show("Выберите тему!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }
        


    }
}
