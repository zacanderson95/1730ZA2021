using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson1D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.013983";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.0017612";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.15528";
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSTAustralia.Text = (
               Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
               ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSTBhutan.Text = (
               Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
               ).ToString("0.00");
        }

        private void costaricaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
               Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
               ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
               Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
               ).ToString("0.00");
        }

        private void txtusdTextChanged(object sender, EventArgs e)
        {
                txtusdTotal.Text = (Convert.ToDecimal(txtUSTAustralia.Text) + Convert.ToDecimal(txtUSTBhutan.Text) + Convert.ToDecimal(txtUSDCostaRica.Text) + 
                Convert.ToDecimal(txtUSDEuro.Text)).ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }




   

