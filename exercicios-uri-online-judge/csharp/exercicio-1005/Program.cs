using System;

namespace exercicio_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo errado corrigir
            double a, b, media, pesoA, pesoB;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            pesoA = 3.5;
            pesoB = 7.5;
            media = (a * pesoA) + (b * pesoB) / pesoA + pesoB;
            Console.WriteLine($"MEDIA = {media.ToString("F5")}");
            Console.ReadLine();
        }
    }
}
