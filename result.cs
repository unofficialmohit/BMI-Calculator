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
    public partial class result : Form
    {
        public result(float x)
        {
                InitializeComponent();
            float y=x;
                if (x > 40)
                    y = 40;
                if (x < 8)
                    y = 8;

            try
                {
                    progressBar1.Value = (int)y;
                    if (x <= 18.5)
                    {
                        progressBar1.ForeColor = System.Drawing.Color.Blue;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You are Underweight";
                    }
                    else if (x > 18.5 && x <= 24.9)
                    {
                        progressBar1.ForeColor = System.Drawing.Color.Green;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You have Normal Weight";
                    }
                    else if (x > 24.9 && x <= 29.9)
                    {
                        progressBar1.ForeColor = System.Drawing.Color.OrangeRed;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You are Overweight";
                    }
                    else if (x > 29.9 && x <= 34.9)
                    {
                        progressBar1.ForeColor = System.Drawing.Color.Red;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You are Obese(Class 1)";
                    }
                    else if (x > 34.9 && x <= 39.9)
                    {
                        progressBar1.ForeColor = System.Drawing.Color.Red;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You are Obese(Class 2)";
                    }
                    else
                    {
                        progressBar1.ForeColor = System.Drawing.Color.Red;
                        label7.Text = "Your Score is " + x;
                        label8.Text = "You are Obese(Class 3)";
                    }
                }
                catch
                {
                    progressBar1.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();

                    MessageBox.Show("INVALID INPUT");
                }

            
            InitializeComponent();

        }
    }
}
