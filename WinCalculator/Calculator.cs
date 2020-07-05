using System;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Calculator : Form
    {
        bool firstRun = true; // Обозначает первый запуск программы либо после нажатия кнопки CE
        bool clear; // Показывает, можно ли стереть данные из поля textBox1 при нажатии кнопки
        bool resultClick = false; // Была ли нажата кнопка математической операции
        double result = 0; // Сохраняет промежуточный результат после каждой математической операции
        string operation = "+"; // Запоминает последнюю нажатую кнопку математической операции. По умолчанию +
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // Обработчик нажатия на кнопку цифры
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

        // Обработчик нажатия на кнопку математической операции
        private void ButtonOperation(string op)
        {
            resultClick = true;
            switch (operation)
            {
                case "+":
                    result += Convert.ToDouble(textBox1.Text);
                    break;
                case "-":
                    result -= Convert.ToDouble(textBox1.Text);
                    break;
                case "*":
                    result *= Convert.ToDouble(textBox1.Text);
                    break;
                case "÷":
                    result /= Convert.ToDouble(textBox1.Text);
                    break;
                default:break;
            }

            // Запоминаем следующую операцию. Если она +, -, * или ÷, то при нажати кнопки цикл начнется сначала
            operation = op;

            // Далее идут операции, которые сразу выводят результат в textBox1
            switch (operation)
            {
                // Операции со специфическим выводом результата в textBox2
                case "²":
                    textBox2.Text += "(" + textBox1.Text + ")" + operation + " ";
                    break;
                case "√":
                    textBox2.Text += operation + "(" + textBox1.Text + ") ";
                    break;
                case "1/":
                    textBox2.Text += operation + "(" + textBox1.Text + ") ";
                    break;
                // Стандартный вывод информации в textBox2 для операций +, -, * или ÷
                default:
                    textBox2.Text += textBox1.Text + " " + operation + " ";
                    break;
            }

            // Обработка специфических команд и вывода информации в textBox1
            switch (operation)
            {
                case "=":
                    textBox1.Text = result.ToString();
                    break;
                case "²":
                    textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), 2).ToString();
                    break;
                case "√":
                    textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "1/":
                    result = 1 / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                default:break;
            }
            clear = true;
        }

        // Кнопки цифр и запятая
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
        private void buttonDoDouble_Click(object sender, EventArgs e) // Запятая (дробное число)
        {
            ButtonNumber(buttonDoDouble);
        }
        #endregion

        // Кнопки математических операций
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

        // Специальные кнопки
        #region OtherButtons
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            firstRun = true;
            resultClick = false; ;
            result = 0;
            operation = "+";
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            resultClick = false;
            textBox1.Text = "0";
        }
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            result = -1 * Convert.ToDouble(textBox1.Text);
            textBox2.Text += "negate(" + textBox1.Text + ") ";
            textBox1.Text = result.ToString();
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (!resultClick)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
        }
        #endregion
    }
}
