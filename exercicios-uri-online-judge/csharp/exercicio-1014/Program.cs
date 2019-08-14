using System;

namespace exercicio_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consumoMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            consumoMedio = x / y;

            Console.WriteLine($"{consumoMedio.ToString("F3")} km/l");

            Console.ReadLine();
        }
    }
}
