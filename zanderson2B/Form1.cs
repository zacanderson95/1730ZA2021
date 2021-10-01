using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal AmountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal RateAustralia = 0.717976m;
            decimal USTAustralia = AmountAustralia * RateAustralia;
            txtUSTAustralia.Text = USTAustralia.ToString("0.00");

            decimal AmountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal RateBhutan = 0.717976m;
            decimal USTBhutan = AmountBhutan * RateBhutan;
            txtAmountBhutan.Text = USTBhutan.ToString("0.00");

            decimal AmountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal RateEuro = 0.717976m;
            decimal USDEuro = AmountEuro * RateEuro;
            txtAmountEuro.Text = USDEuro.ToString("0.00");

            decimal AmountCostaRica = Convert.ToDecimal(txtAmountCostaRica.Text);
            decimal RateCostaRica = 0.717976m;
            decimal USDCostaRica = AmountCostaRica * RateCostaRica;
            txtAmountCostaRica.Text = USDCostaRica.ToString("0.00");



            decimal usdTotal = USTAustralia + USTBhutan + USDCostaRica + USDEuro;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}