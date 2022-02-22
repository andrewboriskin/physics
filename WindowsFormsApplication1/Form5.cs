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

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Visible = true;
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Other closed = new Other();
            if (closed.exit() == false)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Visible = false;
            f3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Download d = new Download();
            int a = d.read();

            Form4 f4 = new Form4();
            if (a == 0)
            {
                foreach (string st in d.kinematika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 1)
            {
                foreach (string st in d.dinamika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 2)
            {
                foreach (string st in d.impuls)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 3)
            {
                foreach (string st in d.rabota)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 4)
            {
                foreach (string st in d.statika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 5)
            {
                foreach (string st in d.gidrostatika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 6)
            {
                foreach (string st in d.mkt)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 7)
            {
                foreach (string st in d.thermodinamica)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 8)
            {
                foreach (string st in d.electrostatika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 9)
            {
                foreach (string st in d.electrotok)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 10)
            {
                foreach (string st in d.magnitfield)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 11)
            {
                foreach (string st in d.kolebaniya)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 12)
            {
                foreach (string st in d.optika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 13)
            {
                foreach (string st in d.sto)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 14)
            {
                foreach (string st in d.kvantphysic)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
            if (a == 15)
            {
                foreach (string st in d.yadernayaph)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(a);
            }
        }

       
        
    }
}
