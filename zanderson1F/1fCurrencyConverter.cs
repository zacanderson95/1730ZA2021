using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picAustraliaDim_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            txtCurrency.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + ": ";
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "0.0139831";
            txtCurrency.Text = "0.00";
            lblCurrency.Text = btnBhutan.Text + ": ";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "0.0017612";
            txtCurrency.Text = "0.00";
            lblCurrency.Text = btnCostaRica.Text + ": ";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "1.15528";
            txtCurrency.Text = "0.00";
            lblCurrency.Text = btnEuro.Text + ": ";
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
               Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtCurrency.Text)
               ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtTotalUSD.Text = (
              Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
              ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblEquation.Text = "0.00";
        }
    }
}
