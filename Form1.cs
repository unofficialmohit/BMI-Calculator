using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;
            
            if (!string.IsNullOrEmpty(value1) && !string.IsNullOrEmpty(value2))
            {
                Form activeForm = Form.ActiveForm;
                if (activeForm != null)
                {
                    activeForm.Hide();
                }
                new bmi(value1,value2).Show();
            }
            else
            {
                MessageBox.Show("Some Fields are not Filled");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            new history().Show();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a letter and not a control character (e.g., backspace), suppress the key press
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
