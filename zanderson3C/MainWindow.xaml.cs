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

namespace _1730ex3c
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = int.Parse(inputTextBox0a.Text);
                resultTextBox0.Text = Ex3cCalculations.Calc0(index).ToString();
            }
            catch
            {
                MessageBox.Show("Testing");
            }

            try
            {
                string search = string.Copy(inputTextBox1a.Text);
                resultTextBox2.Text = Ex3cCalculations.Calc1(search);
            }
            catch
            {
                MessageBox.Show("Testing");
            }

            try
            {
                int[] numbers2 = { 11, 22, 23, 34, 10 };
                resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();
            }
            catch
            {
                MessageBox.Show("Testing");
            }
            double[] numbers = { 11.1, 22.2, 23.3, 34.4, 9.0 };
            int count = 0;
            try
            {
                resultTextBox3.Text = Ex3cCalculations.Calc3(numbers, count).ToString();
            }
            catch
            {
                MessageBox.Show("Testing");
            }

            double[] numbers5 = new double[inputListBox5a.Items.Count];
            double average = Ex3cCalculations.Calc5(numbers5);
            resultTextBox5.Text = average.ToString("n1");

            double[] numbers6 = new double[inputListBox6a.Items.Count];
            for (int i = 0; i < inputListBox6a.Items.Count; i++)
            {
                numbers6[i] = double.Parse(inputListBox6a.Items.GetItemAt(i).ToString());
            }
            Ex3cCalculations.Calc6(numbers6);
            
        }

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
