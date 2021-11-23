using System;
using System.Collections.Generic;
using System.Text;

namespace zanderson3A
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //   {
        //        sum += i;
        //        i++;
        //   }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try {
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
                while (i <= months) ;
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

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}

