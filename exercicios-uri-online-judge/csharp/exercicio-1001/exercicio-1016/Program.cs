using System;

namespace exercicio_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempoNecessario, x;
            distancia = int.Parse(Console.ReadLine());
            x = 2;
            tempoNecessario = distancia * x;

            Console.WriteLine($"{tempoNecessario} minutos");
            Console.ReadLine();
        }
    }
}
