using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730ex3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] days2 = days;
            days2[1] = days[0]; 
            int i = index;
            if (i >= 1 && i <= 7)
                return days2[index];
            else return "Invalid index";

        }

        public static string Calc1(string search)
        {

            search = search.Trim();
            search = search.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search);
            string hours2 = hours[index];
            if (days[index] == search)
                return hours2;

            else return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
                total += number;
            int numbers2 = total;
            return total;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double total = 0.0;
            for (int i = 0; i < count; i++)
                total += numbers[count];
            double sum = total; 
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            double avg = sum / numbers.Length;
            return avg;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (int number in numbers)
                {
                    if (number > avg)
                        aboveAvgList.Add(number);
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}
