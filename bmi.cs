using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class bmi : Form
    {
        private string y,z;
        private string connectionString = "Data Source=MOHIT\\SQLEXPRESS;Initial Catalog=bmi;Integrated Security=True";
        public bmi(string a, string b)
        {
            y = a;
            z = b;
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2= textBox2.Text;

            float w = int.TryParse(textBox1.Text, out int result1) ? result1 : 0;

            float h = int.TryParse(textBox2.Text, out int result2) ? result2 : 0;

            if (w > 200 || w < 10)
            {
                MessageBox.Show("INVALID WEIGHT");
            }
            else if (h > 300 || h < 20)
            {
                MessageBox.Show("INVALID HEIGHT");
            }
            else if (!string.IsNullOrEmpty(value1) && !string.IsNullOrEmpty(value2))
            {

                DateTime currentDate = DateTime.Now;

                // Format the current date in "dd-MM-yyyy" format
                string formattedDate = currentDate.ToString("dd-MM-yyyy");
                h = h / 100;
                float x = (w / (h * h));
                String l = x.ToString();
                string c = "";
                if(x<18.5)
                {
                    c = "Underweight";
                }
                else if (x > 18.5 && x <= 24.9)
                {
                    c = "Normal Weight";
                }
                else if (x > 24.9 && x <= 29.9)
                {
                    c = "OverWeight";
                }
                else if (x > 29.9 && x <= 34.9)
                {
                    c = "Obese (Class 1)";
                }
                else if (x > 34.9 && x <= 39.9)
                {
                    c = "Obese (Class 2)";
                }
                else if (x > 39.9)
                {
                    c = "Obese (Class 2)";
                }


                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO bmi VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Value1", y);
                            command.Parameters.AddWithValue("@Value2", z);
                            command.Parameters.AddWithValue("@Value3", formattedDate);
                            command.Parameters.AddWithValue("@Value4", value1);
                            command.Parameters.AddWithValue("@Value5", value2);
                            command.Parameters.AddWithValue("@Value6", l);
                            command.Parameters.AddWithValue("@Value7", c);



                            connection.Open();

                            command.ExecuteNonQuery();
                           
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("DATABASE ERROR");
                }
                Form activeForm = Form.ActiveForm;
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                new result(x).Show();
            }
            else
            {
                MessageBox.Show("Some Fields are not Filled");
            }


        }
    }
}
