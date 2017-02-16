using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Cost = Convert.ToDouble(CostBox.Text);
            double Paid= Convert.ToDouble(PaidBox.Text);
            
            if(Cost == 0 || Paid == 0)
            {
                MessageBox.Show("The Cost or Paid values cannot be equal to zero", "Incorrect cost/paid values",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Cost > Paid)
            {
                MessageBox.Show("Pay more or get lost", "You idiot!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double changeLeft = Paid - Cost;
                int d5 = 0; int d2 = 0; int d1 = 0; int d05 = 0; int d02 = 0;int d01 = 0;
                int d005 = 0;int d002 = 0;int d001 = 0;
                while (changeLeft >= 5)
                {
                    changeLeft = Math.Round(changeLeft - 5, 2);
                    d5++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 2)
                {
                    changeLeft = Math.Round(changeLeft - 2, 2);
                    d2++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 1)
                {
                    changeLeft = Math.Round(changeLeft - 1, 2);
                    d1++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.5)
                {
                    changeLeft = Math.Round(changeLeft - 0.5, 2);
                    d05++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.2)
                {
                    changeLeft = Math.Round(changeLeft - 0.2, 2);
                    d02++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.1)
                {
                    changeLeft = Math.Round(changeLeft - 0.1, 2);
                    d01++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.05)
                {
                    changeLeft = Math.Round(changeLeft - 0.05, 2);
                    d005++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.02)
                {
                    changeLeft = Math.Round(changeLeft - 0.02, 2);
                    d002++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                while (changeLeft >= 0.01)
                {
                    changeLeft = Math.Round(changeLeft - 0.01, 2);
                    d001++;
                    System.Diagnostics.Debug.WriteLine(changeLeft);
                }
                System.Diagnostics.Debug.WriteLine(changeLeft);
                Text5.Text = d5.ToString();
                Text2.Text = d2.ToString();
                Text1.Text = d1.ToString();
                Text05.Text = d05.ToString();
                Text02.Text = d02.ToString();
                Text01.Text = d01.ToString();
                Text005.Text = d005.ToString();
                Text002.Text = d002.ToString();
                Text001.Text = d001.ToString();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
