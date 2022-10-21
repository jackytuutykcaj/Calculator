using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        string operation = "";
        bool clear = false, equalPressed = false;
        string leftNumber = "", rightNumber = "", result = "";
        string memory = "";
        Form2 helpWindow = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        void append(string number)
        {
            //if the textbox has a zero, clear it.
            if(textBoxInput.Text == "0")
            {
                //if its not a dot, clear it
                if(number != ".")
                {
                    textBoxInput.Clear();
                }
            }
            //clear the textbox if a operation was clicked
            if((operation != "" && clear))
            {
                textBoxInput.Clear();
                clear = false;
            }
            if (equalPressed && clear)
            {
                leftNumber = "";
                rightNumber = "";
                equalPressed = false;
            }
            textBoxInput.AppendText(number);
        }

        void equals(bool equalSign)
        {
            double left = 0, right = 0, result = 0;
            bool error = false;
            //get the right number fromt the textbox after clicking the equal sign
            rightNumber = textBoxInput.Text;
            double.TryParse(leftNumber, out left);
            double.TryParse(rightNumber, out right);

            //check for operation and do operation
            switch (operation)
            {
                case ("add"):
                    result = left + right;
                    break;
                case ("subtract"):
                    result = left - right;
                    break;
                case ("multiply"):
                    result = left * right;
                    break;
                case ("divide"):
                    if(right > 0)
                    {
                        result = left / right;
                    }
                    else
                    {
                        error = !error;
                    }
                    break;
            }
            if (!error)
            {
                textBoxInput.Text = Convert.ToString(result);
                this.result = textBoxInput.Text;
            }
            else
            {
                textBoxInput.Text = "Error";
                error = !error;
            }
            leftNumber = "";
            clear = true;
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            append("1");
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            append("2");
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            append("3");
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            append("4");
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            append("5");
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            append("6");
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            append("7");
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            append("8");
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            append("9");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            append("0");
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            string number = textBoxInput.Text;
            textBoxInput.Clear();
            if(number != "0")
            {
                if (number.Contains("-"))
                {
                    append(number.Substring(1));
                }
                else
                {
                    append("-");
                    append(number);
                }
            }
            else
            {
                append("0");
            }
        }

        private void buttonDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!textBoxInput.Text.Contains("."))
            {
                append(".");
            }
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            string number = textBoxInput.Text;
            textBoxInput.Clear();
            if(number.Length > 1)
            {
                append(number.Substring(0, number.Length - 1));
            }
            if (textBoxInput.Text.Length == 0 || textBoxInput.Text.Equals("-"))
            {
                textBoxInput.Clear();
                append("0");
            }
        }

        private void buttonDeleteCurrent_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "0";
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            double result = 0, number = 0;
            double.TryParse(textBoxInput.Text, out number);
            if(number >= 0)
            {
                result = Math.Sqrt(number);
                this.result = Convert.ToString(result);
                textBoxInput.Text = Convert.ToString(result);
            }
            else
            {
                textBoxInput.Text = "Error";
            }
            operation = "squareroot";
            clear = true;
        }

        private void buttonExponent_Click(object sender, EventArgs e)
        {
            double result = 0, number = 0;
            double.TryParse(textBoxInput.Text, out number);
            result = number * number;
            this.result = Convert.ToString(result);
            textBoxInput.Text = Convert.ToString(result);
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            double result = 0, number = 0;
            double.TryParse(textBoxInput.Text, out number);
            if(number != 0)
            {
                result = 1 / number;
                this.result = Convert.ToString(result);
                textBoxInput.Text = Convert.ToString(result);
            }
            else
            {
                textBoxInput.Text = "Error";
            }
            operation = "reciprical";
            clear = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (leftNumber == "")
            {
                leftNumber = textBoxInput.Text;
                operation = "divide";
                clear = true;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (leftNumber == "")
            {
                leftNumber = textBoxInput.Text;
                operation = "multiply";
                clear = true;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (leftNumber == "")
            {
                leftNumber = textBoxInput.Text;
                operation = "subtract";
                clear = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (leftNumber == "")
            {
                leftNumber = textBoxInput.Text;
                operation = "add";
                clear = true;
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            leftNumber = "";
            rightNumber = "";
            operation = "";
            equalPressed = false;
            clear = false;
            textBoxInput.Clear();
            textBoxInput.Text = "0";
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            memory = textBoxInput.Text;
        }

        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = memory;
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            helpWindow.Show();

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            equals(true);
            equalPressed = true;
        }
    }
}
