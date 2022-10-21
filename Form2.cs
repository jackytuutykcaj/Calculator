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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelHelpText.MaximumSize = new Size(this.Width, this.Height);
            labelHelpText.Text = "<= : Backspace \nCE : Clear current entry \nC : Clear all \n+/-: Negative sign \n√ : Square root \nx*x : Exponent of itself \n1/x : Recipricol \n/ : divide \n* : multiply \n- : subtract \n+ : addition \n. : decimal \n= : equal sign\n\n\n\n" +
                "To use this calculator:\n1. Press a number\n2. Press an operation\n3. Press a number\n4. Press equals";
        }

        private void buttonExitHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
