using System;

namespace exercicio_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, pesoA, b, pesoB, c, pesoC, media;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            pesoA = 2;
            pesoB = 3;
            pesoC = 5;
            media = ((a * pesoA) + (b * pesoB) + (c * pesoC))/ pesoA + pesoB + pesoC;
            Console.WriteLine($"MEDIA = {media}");
            Console.ReadLine();
        }
    }
}
