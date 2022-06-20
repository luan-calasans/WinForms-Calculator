using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculator : Form
    {
        decimal firstValue = 0, secondValue = 0;
        string operatorCalculator = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "10";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtBox.Text += "11";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                firstValue = decimal.Parse(txtBox.Text, CultureInfo.InvariantCulture);
                txtBox.Text = "";
                operatorCalculator = "SUB";
                lblOperator.Text = "-";
            }
            else
            {
                MessageBox.Show("Enter a number to perform the subtraction.");
            }            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                firstValue = decimal.Parse(txtBox.Text, CultureInfo.InvariantCulture);
                txtBox.Text = "";
                operatorCalculator = "MULTI";
                lblOperator.Text = "x";
            }
            else
            {
                MessageBox.Show("Enter a number to perform the multiplication.");
            }            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                firstValue = decimal.Parse(txtBox.Text, CultureInfo.InvariantCulture);
                txtBox.Text = "";
                operatorCalculator = "DIV";
                lblOperator.Text = "/";

            }
            else
            {
                MessageBox.Show("Enter a number to perform the division.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            operatorCalculator = "";
            lblOperator.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstValue = 0;
            secondValue = 0;
            txtBox.Text = "";
            operatorCalculator = "";
            lblOperator.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {            
            secondValue = decimal.Parse(txtBox.Text, CultureInfo.InvariantCulture);

            switch (operatorCalculator)
            {
                case "SUM":
                    txtBox.Text = Convert.ToString(firstValue + secondValue);
                    lblOperator.Text = "";
                    break;

                case "MULTI":
                    txtBox.Text = Convert.ToString(firstValue * secondValue);
                    lblOperator.Text = "";
                    break;

                case "DIV":
                    txtBox.Text = Convert.ToString(firstValue / secondValue);
                    lblOperator.Text = "";
                    break;

                case "SUB":
                    txtBox.Text = Convert.ToString(firstValue - secondValue);
                    lblOperator.Text = "";
                    break;

                default:
                    MessageBox.Show("Enter a number and click on the operator to perform the operation");
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                firstValue = decimal.Parse(txtBox.Text, CultureInfo.InvariantCulture);
                txtBox.Text = "";
                operatorCalculator = "SUM";
                lblOperator.Text = "+";
            }
            else
            {
                MessageBox.Show("Enter a number to perform the sum.");
            }            
        }
    }
}
