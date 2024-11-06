using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week_3_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user_name = "enes";
        int password = 123;
        int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == textBox1.Text && password == Convert.ToInt32(maskedTextBox1.Text))
            {
                MessageBox.Show("Login success","Bombastico",MessageBoxButtons.OK);
                Form1 form1 = new Form1();
                this.Hide();

                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (user_name != textBox1.Text || password != Convert.ToInt32(maskedTextBox1.Text))
            {
                counter++;
                MessageBox.Show("Wrong password or username","Wrong ansver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                maskedTextBox1.Clear();
                if (counter == 3)
                {
                    MessageBox.Show(" You entered the wrong password 3 times.", "Sign In Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
