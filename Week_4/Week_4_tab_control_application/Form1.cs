using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Week_4_tab_control_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            colortext.BackColor = color.Color;
            color.Reset();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Adınız: " + textBox1.Text);
            listBox1.Items.Add("Soyisminiz: " + textBox2.Text);

            listBox1.Items.Add("Yaşınız: " + (DateTime.Now.Year - dateTimePicker1.Value.Year));
            listBox1.Items.Add("İman yeriniz: " + comboBox1.Text);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Dininiz: " + radioButton1.Text);
            }

            if (checkBox1.Checked) listBox1.Items.Add(checkBox1.Text);
            if (checkBox2.Checked) listBox1.Items.Add(checkBox2.Text);
            if (checkBox3.Checked) listBox1.Items.Add(checkBox3.Text);
            progressBar1.Value = 100;

            await Task.Delay(800);

            tab1.SelectedIndex = 1;

            tab1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 20;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 20;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 20;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
        }
    }
}
