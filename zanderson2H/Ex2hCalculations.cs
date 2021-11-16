using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace zanderson2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
          
            return result;


        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;


        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            


            return result;


        }

       public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                TimeSpan dateSpan = DateTime.Parse(strDateA) - DateTime.Parse(strDateB);

                result = dateSpan.TotalDays.ToString() + " days";

            }
            catch { }

            return result;

        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                TimeSpan dateSpan = DateTime.Parse(strDateA) - DateTime.Parse(strDateB);
                if (strDateB > strDateB)
                {
                    result = date.TotalDays.ToString() + " days past due";
                }
                if (strDateA == strDateB)
                {
                    result = "On time";
                }
                result = date.TotalDays.ToString() + " days";

            }
            catch { }

            return result;     

        }
        // String methods
        public static string StringCalc01(string s)
        {
            s = s.Trim();
            try
            {
                s = s.Remove(0, +1);
                return s.Insert(0, "cr");
            }
            catch { }
            return "Invalid input";
        }

        public static string StringCalc02(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(1, +1);
                return s.Insert(1, "rit");
            }
            else return "Invalid input";
            
        }

        public static string StringCalc03(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Substring(3, 6).ToUpper();
                return s.ToUpper();
            }
            else return "Invalid input";
           
            
        }

        public static string StringCalc04(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.PadLeft(10);
                return s.PadLeft('*');
            }
            
            else return "Invalid input";

        }

        public static string StringCalc05(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Replace('(',' ');
                s = s.Replace(')', ' ');
                s = s.Replace(' ', ' ');
                s = s.Replace('-', ' ');
                return s;
            }
            else return "Invalid input";
        }

        public static string StringCalc06(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Replace('(', '.');
                s = s.Replace(')', '.');
                s = s.Replace(' ', '.');
                s = s.Replace('-', '.');
                return s;
            }
            else if (s.Length > 7)
            {
                return s.Remove(s.Length, -1);
            }
            else return "Invalid input";
        }

        public static string StringCalc07(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            if (s.Contains("pioneer"))
            {
                return "Found";
            }
            else return "Not found";
        }

        public static string StringCalc08(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                int Indexs = s.IndexOf(", ") + 1;
                return s;
            }
            else return "Invalid input";
        }

        public static string StringCalc09(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                int Indexs = s.LastIndexOf(" ") + 1;
                return s;
            }
            else return "Invalid input";
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            return "";
        }


    }
}