using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Midterms
{
    public partial class BMICalculatorForm : Form
    {
        private string username;
        public BMICalculatorForm(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameText.Text = " " + username;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(weightTextBox.Text, out double weight) &&
                double.TryParse(heightTextBox.Text, out double height))
            {
                double bmi = CalculateBMI(weight, height);
                bmiLabel.Text = $" {bmi:F2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid weight and height values. ");
            }
        }
        private double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
