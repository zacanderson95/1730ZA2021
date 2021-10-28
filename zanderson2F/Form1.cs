using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            //#1
            subtotal = decimal.Parse(input1aTextBox.Text);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            result1TextBox.Text = discountPercent.ToString("n2");

            //#2
            subtotal = decimal.Parse(input2aTextBox.Text);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: ";
            }
            result2TextBox.Text = status + discountPercent.ToString("n2");

            //#3
            subtotal = decimal.Parse(input3aTextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            result3TextBox.Text = discountPercent.ToString("n2");

            //#4
            subtotal = decimal.Parse(input4aTextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else 
                discountPercent = 0.1m;
            result4TextBox.Text = discountPercent.ToString("n2");

            //#5
            subtotal = decimal.Parse(input5aTextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            result5TextBox.Text = discountPercent.ToString("n2");

            //#6
            subtotal = decimal.Parse(input6aTextBox.Text);
            string customerType = (input6bTextBox.Text);
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            result6TextBox.Text = discountPercent.ToString("n2");

            //#7
            result7TextBox.Text = discountPercent.ToString("n2");

            //#8
            result8TextBox.Text = discountPercent.ToString("n2");

            //#9
            result9TextBox.Text = discountPercent.ToString("n2");

            //#10
            result10TextBox.Text = discountPercent.ToString("n2");

        }

    }
}
