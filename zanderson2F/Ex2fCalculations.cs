using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanderson2F
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2 if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
             return status;

        }

        public static string Calc03(string input)
        {
            // #3 if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
           
        }

        public static string Calc04(string input)
        {
            //#4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
            
        }

        public static string Calc05(string input)
        {
            //#5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");

        }

        public static string Calc06(string inputA, string inputB)
        {
            //#6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(inputA);
            string customerType = (inputB);
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
            return discountPercent.ToString("n2");

        }

        public static string Calc07(string input)
        {
            //#7 Validate input: non-empty string
                decimal ethereum = 0m;
                if (input != "")
                {
                decimal dollars = decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
                }
                return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            
            if (inputA != "" && inputB != "")
            {
                decimal total = 0m;
                decimal addition = 0m;
                decimal dollars = decimal.Parse(inputA);
                total = ((2m * dollars) + addition);
                if (total < 50m)
                    addition = 5m; 
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            if (inputA != "" && inputB != "")
            {
                decimal total = 0m;
                decimal first = decimal.Parse(inputA);
                decimal second = decimal.Parse(inputB);
                total = second - first;
                return total.ToString("n2");
            }

                return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            if (inputA != "" && inputB != "")
            {
                Int32 total = 0;
                Int32 first = Int32.Parse(inputA);
                Int32 second = Int32.Parse(inputB);
                if (first > second)
                    total = first / second;
                else if (second > first)
                    total = second / first;
                return total.ToString("n2");
            }
            return "Invalid input";
        }
    }
}
