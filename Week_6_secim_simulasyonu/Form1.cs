using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6_secim_simulasyonu
{
    public partial class Form1 : Form
    {
        private string username = "enes";
        private int password = 123;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (username == user_name.Text && password == Convert.ToInt32(passwordBox.Text))
            {
                MessageBox.Show("Congrulations!!! Username and Password are True.....",
                    "Sign In Panel", MessageBoxButtons.OK);

                Form1 form1 = new Form1();
                this.Hide();
                secim_form form2 = new secim_form();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Username or Password are WRONG....",
                    "Sign In Panel", MessageBoxButtons.OK);
            }
        }


        private void bunifuFormCaptionButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
