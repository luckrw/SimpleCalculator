using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string userInput = "";
        string first = "", second = "";
        char action;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "0";
            lbl_display.Text += userInput;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "1";
            lbl_display.Text += userInput;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "2";
            lbl_display.Text += userInput;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "3";
            lbl_display.Text += userInput;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "4";
            lbl_display.Text += userInput;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "5";
            lbl_display.Text += userInput;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "6";
            lbl_display.Text += userInput;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "7";
            lbl_display.Text += userInput;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "8";
            lbl_display.Text += userInput;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += "9";
            lbl_display.Text += userInput;
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "";
            userInput += ".";
            lbl_display.Text += userInput;
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            action = '+';
            first = userInput;
            userInput = "";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            action = '-';
            first = userInput;
            userInput = "";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            action = '*';
            first = userInput;
            userInput = "";
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            action = '/';
            first = userInput;
            userInput = "";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            double num1, num2;
            num1 = double.Parse(first);
            num2 = double.Parse(second);

            if (action == '+')
            {
                result = num1 + num2;
            }

            else if (action == '-')
            {
                result = num1 - num2;
            }

            else if (action == '*')
            {
                result = num1 * num2;
            }

            else if (action == '/')
            {
                if(num2 == 0)
                {
                    lbl_display.Text = "Cannot Divide a number by Zero!";
                }

                else
                {
                    result = num1 / num2;
                }
            }

            lbl_display.Text = result.ToString();
            userInput = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            lbl_display.Text = "0";
        }

        

        

        

        
    }
}
