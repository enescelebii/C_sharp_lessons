using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6_secim_simulasyonu
{
    public partial class secim_form : Form
    {
        public secim_form()
        {
            InitializeComponent();
        }

        private void secim_form_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private Random random = new Random();
        private int r1, r2, r3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            r1 = random.Next(10);
            r2 = random.Next(10);
            r3 = random.Next(10);


            bunifuCircleProgress1.Value += r1;
            bunifuCircleProgress2.Value += r2;
            bunifuCircleProgress3.Value += r3;


            if (bunifuCircleProgress1.Value >= 95 || bunifuCircleProgress2.Value >= 95 ||
                bunifuCircleProgress3.Value >= 95)
            {
                timer1.Stop();
                if (bunifuCircleProgress1.Value > bunifuCircleProgress2.Value && bunifuCircleProgress1.Value > bunifuCircleProgress2.Value)
                {
                    MessageBox.Show("Seçimi kazanan A Partisi");
                }else if (bunifuCircleProgress2.Value > bunifuCircleProgress1.Value && bunifuCircleProgress2.Value > bunifuCircleProgress3.Value)
                {
                    MessageBox.Show("Seçimi kazanan B Partisi");
                }
                else
                {
                    MessageBox.Show("Seçimi kazanan C Partisi");

                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress2.Value = 0;
            bunifuCircleProgress3.Value = 0;
            timer1.Start();
        }
    }
}
