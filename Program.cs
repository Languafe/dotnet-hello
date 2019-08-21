using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

            Console.WriteLine("Fibonacci Numbers 1-15:");

            var generator = new FibonacciGenerator();
            int index = 0;
            foreach (var i in generator.Generate(15))
            {
                Console.WriteLine($"{++index}: {i}");
            }
        }
    }
}