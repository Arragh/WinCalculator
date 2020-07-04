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
            textBox2.Text += textBox1.Text + " " + operation + " ";

            if (operation == "=")
            {
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
        #endregion
    }
}
