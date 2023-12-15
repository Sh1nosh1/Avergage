using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace горпгор
{
    internal class Program
    {
        public static double Func(double n, double count)
        {
            return count / n;
        }
        static void Main(string[] args)
        {
            Write("Enter the quantity of numbers you want to enter: ");
            double n = Convert.ToDouble(ReadLine());
            double[] numbers = new double[(int)n];
            double count = 0;
            WriteLine();
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Write($"Enter {i + 1} number: ");
                numbers[i] = Convert.ToDouble(ReadLine());
                count += numbers[i];
            }

            double arithmetic = Func(n, count);

            Write($"\nThe arithmetic mean: {arithmetic}");
            ReadKey();

        }
    }
}
