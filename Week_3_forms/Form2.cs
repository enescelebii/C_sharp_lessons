using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_forms
{
    public partial class Form2 : Form
    {
        char _proces_type;
        bool _clear_screen;
        int _first_number;
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "0";
        }

        private void number1_button_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_label.Text = "";
                _clear_screen = false;
            }

            if (Screen_label.Text == "0") Screen_label.Text = "";
            Screen_label.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _proces_type = '+';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_label.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _proces_type = '-';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_label.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _proces_type = '*';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_label.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _proces_type = '/';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_label.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Screen_label.Text = "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int second_number = Convert.ToInt16(Screen_label.Text);
            double result;

            switch (_proces_type)
            {
                case '+':
                    result = _first_number + second_number;
                    break;
                case '-':
                    result = _first_number - second_number;
                    break;
                case '*':
                    result = _first_number * second_number;
                    break;
                case '/':
                    result = _first_number / second_number;
                    break;
                default:
                    result = 0;
                    break;
            }
            Screen_label.Text = Convert.ToString(result);
        }
    }
}
