using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    internal class Fibonacci
    {
        public int ParseInput(string input)
        {
            if (!int.TryParse(input, out int value))
            {
                throw new FormatException($"Значение '{input}' не является целым числом.");
            }
            return value;
        }

        public int Fib(int n)
        {
            if (n < 0) throw new ArgumentException("n должно быть положительным целым числом.");

            if (n == 0 || n == 1) return n;


            return (Fib(n - 1) + Fib(n - 2));
        }

        public void PrintFibonacci(int n)
        {
            Console.Write("0 ");
            for (int i = 1; i <= n; i++)
            {
                int fibonacciNumber = Fib(i);
                Console.Write(fibonacciNumber + " ");
            }
        }

        public int Fib2(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n должно быть положительным числом.");
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                int previous = 1;
                int current = 1;
                int result = 0;

                for (int i = 3; i <= n; i++)
                {
                    result = previous + current;
                    previous = current;
                    current = result;
                }

                return result;
            }
        }

        public void PrintFib2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                int fibon = Fib2(i);
                Console.Write(fibon + " ");
            }
        }
    }
}
