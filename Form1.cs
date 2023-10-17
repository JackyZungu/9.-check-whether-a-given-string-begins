using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.check_whether_a_given_string_begins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            string result = " ";

            if (input.StartsWith("F") && input.EndsWith("B"))
            {
                result = "Fizz";
            }
            else if (input.StartsWith("F"))
            {
                result = "Fizz";
            }
            else if (input.EndsWith("B"))
            {
                result = "Buzz";
            }
            else
            {
                result = input;
            }

            textBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text= string.Empty;    
        }
    }
}
