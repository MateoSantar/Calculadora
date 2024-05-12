using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "8";

        }

        private void equals_Click(object sender, EventArgs e)
        {
            string equation = equationLabel.Text;
            if (equation.Equals(""))
            {
                MessageBox.Show("Ingrese una función");
            }
            else
            {
                equationLabel.Text = Evaluate(equation).ToString();
            }
        }
        private static dynamic Evaluate(string expression)
        {
            DataTable dt = new DataTable();
            dynamic answer = dt.Compute(expression, "");
            return (dynamic)answer;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            equationLabel.Text = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "0";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "9";
        }

        private void div_Click(object sender, EventArgs e)
        {
            equationLabel.Text += " / ";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            equationLabel.Text += " * ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            equationLabel.Text += " - ";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            equationLabel.Text += " + ";
        }

        private void six_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "7";

        }

        private void four_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "4";

        }

        private void five_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "5";

        }

        private void one_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "2";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            equationLabel.Text += ".";
        }
    }
}
