using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4_create_circle
{
    public partial class Form1 : Form
    {

        const double pi = Math.PI;
        public Form1()
        {
            InitializeComponent();
        }

        private void alanHesapla_Click(object sender, EventArgs e)
        {
            string result = Convert.ToString(Convert.ToDouble(textBox1.Text) * pi * pi);

            pictureBox1.Width = Convert.ToInt32(textBox1.Text) * 20;
            pictureBox1.Height = Convert.ToInt32(textBox1.Text) * 20;
            pictureBox1.Location = new Point(250, 50);

            MessageBox.Show("Dairenin alanı: " + result);
        }

        private void calculateParameter_Click(object sender, EventArgs e)
        {
            string result = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2 * pi);
            pictureBox1.Width = Convert.ToInt32(textBox1.Text) * 20;
            pictureBox1.Height = Convert.ToInt32(textBox1.Text) * 20;

            MessageBox.Show("Dairenin çevresi: " + result);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
