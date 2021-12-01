using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zanderson3B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                this.resultTextBox0.Text = "";
                MessageBox.Show("Invalid input" + this.inputTextBox0a.Text);
            }
            //1
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox1a.Text);
                decimal discountPercent;
                    Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                this.resultTextBox1.Text = "";
                MessageBox.Show("Invalid input" + this.inputTextBox1a.Text);
            }
            //2
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch 
            {
                this.resultTextBox2.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }
            //3
            try
            {
                int months = Int32.Parse(this.inputTextBox3a.Text);
                decimal monthlyInvestment = decimal.Parse(this.inputTextBox3b.Text);
                decimal monthlyInterestRate = decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                this.resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }
            //4
            try
            {
                double fahrenheit = double.Parse(this.inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextBox4.Text = celsius.ToString("f1");
            }
            catch
            {
                this.resultTextBox4.Text = "";
                MessageBox.Show("Invalid input" + this.inputTextBox4a.Text);
            }
            //5
            try
            {
                double celsius = double.Parse(this.inputTextBox5a.Text);
                double fahrenheit; 
                    Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                this.resultTextBox5.Text = "";
                MessageBox.Show("Invalid input" + this.inputTextBox5a.Text);
            }
            //6
            try
            {
                decimal hours = decimal.Parse(this.inputTextBox6a.Text);
                decimal rate = decimal.Parse(this.inputTextBox6b.Text);
                decimal totalpay = Ex3bCalculations.GrossPay(hours, rate);
                resultTextBox6.Text = totalpay.ToString("n2");
            }
            catch
            {
                this.resultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text + "\n");
            }
            //7
            try
            {
                this.resultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input" + inputTextBox7a.Text);
                 
            }
            //8
            try
            {
                decimal rate = decimal.Parse(this.inputTextBox8b.Text);
                this.resultTextBox8.Text =
                    Ex3bCalculations.GrossPay(this.inputTextBox8a.Text, rate).ToString("n2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text + "\n");
            }
        }
    }
}
