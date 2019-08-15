using System;

namespace exercicio_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendasVendedor, porcentagem, salarioTotal;
            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            totalVendasVendedor = double.Parse(Console.ReadLine());

            porcentagem = 0.15;
            salarioTotal = salario + (totalVendasVendedor * porcentagem);

            Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2")}");

            Console.ReadLine();
        }
    }
}
