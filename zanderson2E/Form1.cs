﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson2E
{
    public partial class zanderson2E : Form
    {
        public zanderson2E()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            result1TextBox.Text = "";
            result2TextBox.Text = "";
            result3aTextBox.Text = "";
            result3bTextBox.Text = "";
            result4aTextBox.Text = "";
            result4bTextBox.Text = "";
            result5aTextBox.Text = "";
            result5bTextBox.Text = "";
            result6aTextBox.Text = "";
            result6bTextBox.Text = "";
            result7TextBox.Text = "";
            result8TextBox.Text = "";
            result9aTextBox.Text = "";
            result9bTextBox.Text = "";



            // #1
            decimal subtotal = Convert.ToDecimal(input1aTextBox.Text);
            result1TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();

            // #2.

            int timeInService = Convert.ToInt32(input2aTextBox.Text);
            result2TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();

            // #3

            bool isValid = Convert.ToBoolean(input3aTextBox.Text);
            int years = Convert.ToInt32(input3cTextBox.Text);
            //
            int counter = Convert.ToInt32(input3bTextBox.Text);
            result3aTextBox.Text = (isValid == true && counter++ < years).ToString();
            result3bTextBox.Text = counter.ToString();

            // #4

            counter = Convert.ToInt32(input3bTextBox.Text);
            result4aTextBox.Text = (isValid == true & counter++ < years).ToString();
            result4bTextBox.Text = counter.ToString();

            // #5

            counter = Convert.ToInt32(input3bTextBox.Text);
            result5aTextBox.Text = (isValid == true || counter++ < years).ToString();
            result5bTextBox.Text = counter.ToString();

            // #6

            counter = Convert.ToInt32(input3bTextBox.Text);
            result6aTextBox.Text = (isValid == true | counter++ < years).ToString();
            result6bTextBox.Text = counter.ToString();

            // #7

            DateTime startDate = Convert.ToDateTime(input7aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input7bTextBox.Text);
            DateTime date = Convert.ToDateTime(input7cTextBox.Text);
            isValid = Convert.ToBoolean(input7dTextBox.Text);
            result7TextBox.Text = (date > startDate && date < expirationDate || isValid == true).ToString();

            // #8

            decimal thisYTD = Convert.ToDecimal(input8aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input8bTextBox.Text);
            string empType = input8cTextBox.Text;
            int startYear = Convert.ToInt32(input8dTextBox.Text);
            int currentYear = Convert.ToInt32(input8eTextBox.Text);
            result8TextBox.Text = (((thisYTD > lastYTD) || empType == "part time") && startYear < currentYear).ToString();

            // #9

            counter = Convert.ToInt32(input9aTextBox.Text);
            years = Convert.ToInt32(input9bTextBox.Text);
            result9aTextBox.Text = (!(++counter >= years)).ToString();
            result9bTextBox.Text = counter.ToString();

            // #9
            int a = Convert.ToInt32(input10aTextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            result10TextBox.Text = (a > b && (b < c || c < d)).ToString();



        }

    }
}
