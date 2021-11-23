using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanderson3A2
{
    public class Ex3aLoops
    {
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double montlypayment = double.Parse(strMonthlyPayment);
                double montlyinterestrate = double.Parse(strMonthlyInterestRate);

                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + montlypayment) * (1 + montlyinterestrate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double montlypayment = double.Parse(strMonthlyPayment);
                double montlyinterestrate = double.Parse(strMonthlyInterestRate);

                int i = 1;
                do
                {
                    futureValue = (futureValue + montlypayment) * (1 + montlyinterestrate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");

        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double montlypayment = double.Parse(strMonthlyPayment);
                double montlyinterestrate = double.Parse(strMonthlyInterestRate);

                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + montlypayment) * (1 + montlyinterestrate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }

        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);

                int i = start;
                while (i < end)
                {
                    result = (result += i) + (" ");
                    i+=increment;
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);

                int i = start;
                do
                {
                    result = (result += i) + (" ");
                    i += increment;
                }
                while (i < end);
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);

                for (int i = start; i < end; i += increment)
                {
                    result = (result += i) + (" ");
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;
            try
            {
                int i = 1;
                int count = Int32.Parse(strCount);
                while (i <= count)
                    { 
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                int number = Int32.Parse(strNumber);
                    sum += number;
                startIndex = endIndex + 1;
                    i++;
                   }
                result = sum.ToString();
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;
            try
            {
                int i = 1;
                int count = Int32.Parse(strCount);
                do
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIndex = endIndex + 1;
                    i++;
                }
                while (i <= count);
                result = sum.ToString();
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;
            try
            {
                
                int count = Int32.Parse(strCount);
                for (int i = 1; i <= count; i++)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIndex = endIndex + 1;
                    
                }
                result = sum.ToString();
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }
    }
}

