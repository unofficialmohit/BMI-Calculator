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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bmiDataSet1.bmi' table. You can move, or remove it, as needed.
            this.bmiTableAdapter1.Fill(this.bmiDataSet1.bmi);
            // TODO: This line of code loads data into the 'bmiDataSet.bmi' table. You can move, or remove it, as needed.
            this.bmiTableAdapter.Fill(this.bmiDataSet.bmi);

        }
    }
}
