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
            decimal txtAmountAustralia = 0m;
            decimal txtRateAustralia = 0.717976m;
            decimal txtUSTAustralia = txtAmountAustralia * txtRateAustralia;

            decimal txtAmountBhutan = 0m;
            decimal txtRateBhutan = 0.013983m;
            decimal txtUSTBhutan = txtAmountBhutan * txtRateBhutan;

            decimal txtAmountCostaRica = 0m;
            decimal txtRateCostaRica = 0.0017612m;
            decimal txtUSDCostaRica = txtAmountCostaRica * txtRateCostaRica;

            decimal txtAmountEuro = 0m;
            decimal txtRateEuro = 1.15528m;
            decimal txtUSDEuro = txtAmountEuro * txtRateEuro;

            decimal txtusdTotal = txtUSTAustralia + txtUSTBhutan + txtUSDCostaRica + txtUSDEuro;

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