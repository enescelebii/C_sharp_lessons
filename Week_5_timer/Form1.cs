using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_timer
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }

        private int saat = 0;
        private int dakika = 0;
        private int saniye = 0;
        private int salise = 0;


        private void butonBasla_Click(object sender, EventArgs e)
        {
            timerKronometre.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerKronometre.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;

            krSalise.Text = salise.ToString();
            Krsaniye.Text = krSalise.ToString();
            krDakika.Text = String.Format("{0:00}", dakika);
            krSaat.Text = String.Format("{0:00}", saat);
            listBox1.Items.Clear();

        }

        

        private void timerKronometre_Tick(object sender, EventArgs e)
        {
            salise++;
            krSalise.Text = salise.ToString();
            if (salise == 60)
            {
                salise = 0;
                saniye++;
            }

            if (saniye ==60)
            {
                saniye = 0;
                dakika++;
                
            }

            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            if (saat == 2)
            {
                Application.Exit();
            }

            krSalise.Text = salise.ToString();
            Krsaniye.Text = saniye.ToString();
            krDakika.Text = String.Format("{0:00}", dakika);
            krSaat.Text = String.Format("{0:00}", saat);



        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {

            labelTarih.Text = "Tarih: " + DateTime.Now.ToLongDateString();
            TarihSaat.Text = "Saat: " + DateTime.Now.ToLongTimeString();
            Random rnd = new Random();
            int r = rnd.Next(255);
            int g = rnd.Next(255);
            int b = rnd.Next(255);


            KronometreBaslık.ForeColor = Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerSaat.Start();
        }
    }
}
