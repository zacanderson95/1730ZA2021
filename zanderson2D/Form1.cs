using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "3";
            textBox10InputB.Text = "3";
        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "asdf";
            textBox2Input.Text = "asdf";
            textBox3Input.Text = "3.3";
            textBox4Input.Text = "True";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "400";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "fail";
            textBox2ResultA.Text = "fail";
            textBox3ResultA.Text = "fail";
            textBox4ResultA.Text = "fail";
            textBox5ResultA.Text = "fail";
            textBox6ResultA.Text = "fail";
            textBox7ResultA.Text = "fail";
            textBox8ResultA.Text = "fail";
            textBox9ResultA.Text = "fail";
            textBox10ResultA.Text = "fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "fail";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 != false)
                textBox4ResultB.Text = "fail";

            int val5 = Convert.ToInt32(textBox5InputA.Text);
            int val6 = Convert.ToInt32(textBox5InputB.Text);
            if (val5 == val6)
                textBox5ResultA.Text = "Success";
            if (val5 != val6)
                textBox5ResultB.Text = "fail";

            if (textBox6Input.Text != "Jones")
                textBox6ResultA.Text = "Success";
            if (textBox6Input.Text == "Jones")
                textBox6ResultB.Text = "fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0)
                textBox7ResultA.Text = "Success";
            if (val7 <= 0)
                textBox7ResultB.Text = "fail";
           
            decimal val8 = Convert.ToDecimal(textBox8InputA.Text);
            decimal val9 = Convert.ToDecimal(textBox8InputB.Text);
            if (val8 < val9)
                textBox8ResultA.Text = "Success";
            if (val8 >= val9)
                textBox8ResultB.Text = "fail";

            decimal val10 = Convert.ToDecimal(textBox9Input.Text);
            if (val10 >= 500)
                textBox9ResultA.Text = "Success";
            if (val10 < 500)
                textBox9ResultB.Text = "fail";

            decimal val11 = Convert.ToDecimal(textBox10InputA.Text);
            decimal val12 = Convert.ToDecimal(textBox10InputB.Text);
            if (val11 <= val12)
                textBox10ResultA.Text = "Success";
            if (val11 > val12)
                textBox10ResultB.Text = "fail";

        }

    }
    }
