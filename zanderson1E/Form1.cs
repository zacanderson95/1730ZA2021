using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson1E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAverageTotal.Text = ((Convert.ToDecimal(txtTest1Amount.Text) + Convert.ToDecimal(txtTest2Amount.Text)
                + Convert.ToDecimal(txtTest3Amount.Text)) / 3m).ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTest1Amount.Text = "0";
            txtTest2Amount.Text = "0";
            txtTest3Amount.Text = "0";
            txtAverageTotal.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
