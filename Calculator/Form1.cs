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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(fnumber.Text) + Convert.ToDouble(snumber.Text);
            result.Text = Convert.ToString(sum);
        }

        private void deduct_Click(object sender, EventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(fnumber.Text) - Convert.ToDouble(snumber.Text);
            result.Text = Convert.ToString(sum);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(fnumber.Text) * Convert.ToDouble(snumber.Text);
            result.Text = Convert.ToString(sum);
        }

        private void share_Click(object sender, EventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(fnumber.Text) / Convert.ToDouble(snumber.Text);
            result.Text = Convert.ToString(sum);
        }
    }
}
