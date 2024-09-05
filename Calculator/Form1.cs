using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txtDisplay.Text = currentCalculation;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {

                txtDisplay.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = txtDisplay.Text;

            }
            catch (Exception ex)
            {
                txtDisplay.Text = "ERROR";
                currentCalculation = "";
            }
        }
        private void button_Clear_click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            currentCalculation = "";
        }
        private void button_clearEntery_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                //1+1
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);

            }
            txtDisplay.Text = currentCalculation;
        }
    }
}
