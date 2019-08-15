using System;

namespace exercicio_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, maiorTodos;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            maior = (a + b + (Math.Abs(a - b))) / 2;
            maiorTodos = (maior + c + (Math.Abs(maior - c))) / 2;

            Console.WriteLine($"{maiorTodos} eh o maior");

            Console.ReadLine();
        }
    }
}
