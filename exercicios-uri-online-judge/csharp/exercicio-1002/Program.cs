using System;

namespace exercicio_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, n, a;
            r = double.Parse(Console.ReadLine());
            n = 3.14159;
            r = Math.Pow(r, 2);
            a = n * r;
            Console.WriteLine($"A={a.ToString("F4")}");
            Console.ReadLine();
        }
    }
}
