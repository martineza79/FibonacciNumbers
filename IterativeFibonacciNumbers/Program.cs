using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeFibonacciNumbers
{
    public class Program
    {
        public static int FibonacciSeries(int n)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            if (n == 0) return 0; // returns first Fibonacci number
            if (n == 1) return 1;  // returns second Fibonacci number

            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
        }
    }
}
