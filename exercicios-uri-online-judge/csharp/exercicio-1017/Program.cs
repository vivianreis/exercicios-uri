using System;

namespace exercicio_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia; 
            double distancia, capacidadeCarroLitro, qtdLitrosNecesaria;
            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            capacidadeCarroLitro = 12;
            distancia = velocidadeMedia * tempoGasto;
            qtdLitrosNecesaria = distancia/capacidadeCarroLitro;

            Console.WriteLine($"{qtdLitrosNecesaria.ToString("F3")}");
            
            Console.ReadLine();
        }
    }
}
