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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            listBox1.Items.Add("Кинематика");
            listBox1.Items.Add("Динамика");
            listBox1.Items.Add("Импульс");
            listBox1.Items.Add("Работа. Мощность. Энергия");
            listBox1.Items.Add("Статика");
            listBox1.Items.Add("Гидростатика");
            listBox1.Items.Add("Молекулярно-кинетическая теория (МКТ)");
            listBox1.Items.Add("Термодинамика");
            listBox1.Items.Add("Электростатика");
            listBox1.Items.Add("Электрический ток");
            listBox1.Items.Add("Магнитное поле тока");
            listBox1.Items.Add("Колебания");
            listBox1.Items.Add("Оптика");
            listBox1.Items.Add("Специальная теория относительности");
            listBox1.Items.Add("Квантовая физика");
            listBox1.Items.Add("Основы ядерной физики");

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Other closed = new Other();
            if (closed.exit() == false)
                e.Cancel = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Download d = new Download();

            Form4 f4 = new Form4();
            if (listBox1.SelectedIndex == 0)
            {
                foreach (string st in d.kinematika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 1)
            {
                foreach (string st in d.dinamika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 2)
            {
                foreach (string st in d.impuls)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 3)
            {
                foreach (string st in d.rabota)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 4)
            {
                foreach (string st in d.statika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 5)
            {
                foreach (string st in d.gidrostatika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 6)
            {
                foreach (string st in d.mkt)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 7)
            {
                foreach (string st in d.thermodinamica)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 8)
            {
                foreach (string st in d.electrostatika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 9)
            {
                foreach (string st in d.electrotok)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 10)
            {
                foreach (string st in d.magnitfield)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 11)
            {
                foreach (string st in d.kolebaniya)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 12)
            {
                foreach (string st in d.optika)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 13)
            {
                foreach (string st in d.sto)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 14)
            {
                foreach (string st in d.kvantphysic)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == 15)
            {
                foreach (string st in d.yadernayaph)
                {
                    f4.listBox1.Items.Add(st);
                }
                f4.Visible = true;
                this.Visible = false;
                d.write(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тему!","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


    }
}
