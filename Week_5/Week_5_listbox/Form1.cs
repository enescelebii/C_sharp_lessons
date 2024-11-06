using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID, name , surname, p_number, job;
            ID = textBox1.Text;
            name = textBox2.Text;
            surname = textBox3.Text;
            p_number = textBox4.Text;
            job = textBox5.Text;

            string[] colum = { ID, name, surname, p_number, job };
            ListViewItem records = new ListViewItem(colum);
            listView1.Items.Add(records);
        }

       
    }
}
