using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanderson3B
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            
            else 
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;

            else
                discountPercent = 0.1m;

        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);
            return celsius;
        }

        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * (9.0 / 5.0) + 32.0);
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            if (hours <= 40m) { 
            decimal totalpay = 0m;
            totalpay = (hours * rate);
            return totalpay;
            }
            else
            {
                decimal totalpay = (rate * 40m) + ((hours - 40m) * rate * 1.5m);
                return totalpay;
            }
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(" "))
            {
                int endIndex = strNumbers.IndexOf(" ", startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal grosspay = 0;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(" "))
            {
                int endIndex = strNumbers.IndexOf(" ", startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                grosspay += number * rate;
                startIndex = endIndex + 1;
            }
            return grosspay;
        }
    }
}
