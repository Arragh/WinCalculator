using System;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Calculator : Form
    {
        bool firstRun = true;
        double result = 0;
        string operation = "+";
        bool clear;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNumber(Button button)
        {
            if (firstRun)
            {
                textBox1.Text = "";
                firstRun = false;
            }
            if (clear)
            {
                textBox1.Text = "";
                clear = false;
            }
            textBox1.Text += button.Text;
        }
        private void ButtonOperation(string op)
        {
            if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            if (operation == "*")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            if (operation == "÷")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }

            operation = op;
            if (operation == "²")
            {
                textBox2.Text += "(" + textBox1.Text + ")" + operation + " ";
            }
            else if(operation == "√")
            {
                textBox2.Text += operation + "(" + textBox1.Text + ") ";
            }
            else if (operation == "1/")
            {
                textBox2.Text += operation + "(" + textBox1.Text + ") ";
            }
            else
            {
                textBox2.Text += textBox1.Text + " " + operation + " ";
            }

            if (operation == "=")
            {
                textBox1.Text = result.ToString();
            }
            if (operation == "²")
            {
                textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), 2).ToString();
            }
            if (operation == "√")
            {
                textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (operation == "1/")
            {
                result = 1/Convert.ToDouble(textBox1.Text);
                textBox1.Text = result.ToString();
            }

            clear = true;
        }

        #region Numbers
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonNumber(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonNumber(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonNumber(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonNumber(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonNumber(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonNumber(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonNumber(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonNumber(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonNumber(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonNumber(button0);
        }

        private void buttonDoDouble_Click(object sender, EventArgs e)
        {
            ButtonNumber(buttonDoDouble);
        }
        #endregion

        #region Operations
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ButtonOperation("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ButtonOperation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            ButtonOperation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            ButtonOperation("÷");
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            ButtonOperation("=");
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            ButtonOperation("²");
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            ButtonOperation("√");
        }

        private void buttonDivideNumber_Click(object sender, EventArgs e)
        {
            ButtonOperation("1/");
        }

        #endregion

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            firstRun = true;
            result = 0;
            operation = "+";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
