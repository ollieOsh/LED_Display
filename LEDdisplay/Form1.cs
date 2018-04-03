using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDdisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckStringIsAlphaNum(string str)
        {
            return str.All(char.IsLetterOrDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool isAlphaNum = CheckStringIsAlphaNum(input);

            if(isAlphaNum && input.Length < 101)
            {
                textBox2.Text = input;
            }
            else if(!isAlphaNum)
            {
                MessageBox.Show("Please remove any special characters");
            }
            else
            {
                MessageBox.Show("Your input is too long");
            }
        }
    }
}
