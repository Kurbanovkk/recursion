using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch iterativeStopwatch = new Stopwatch();
            var fibonacci = new Fibonacci();
            Console.WriteLine("Введите число n, нахождения n-го члена последовательности Фибоначчи");
            var value = Console.ReadLine();
            var n = fibonacci.ParseInput(value);
            fibonacci.PrintFibonacci(n);

            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine();

            fibonacci.PrintFib2(n);
            Console.WriteLine();

            iterativeStopwatch.Start();
            fibonacci.Fib(n);
            iterativeStopwatch.Stop();
            Console.WriteLine($"рекурсия отработала за {iterativeStopwatch.ElapsedMilliseconds} ms, {iterativeStopwatch.ElapsedTicks} ticks");
            iterativeStopwatch.Reset();

            iterativeStopwatch.Start();
            fibonacci.Fib2(n);
            iterativeStopwatch.Stop();
            Console.WriteLine($"цикл отработал за {iterativeStopwatch.ElapsedMilliseconds} ms, {iterativeStopwatch.ElapsedTicks} ticks");

        }
    }
}
