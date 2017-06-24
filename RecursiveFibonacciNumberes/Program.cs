using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacciNumberes
{
    public class Program
    {
        public static int FibonaccciSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonaccciSeries(n - 1) + FibonaccciSeries(n - 2);
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonaccciSeries(i));
            }
            Console.ReadKey();
        }
    }
}
