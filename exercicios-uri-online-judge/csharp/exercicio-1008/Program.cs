using System;

namespace exercicio_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEmpregado, qtdHorasTrabalhadas;
            double valorHora, salario;
            numeroEmpregado = int.Parse(Console.ReadLine());
            qtdHorasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());

            salario = qtdHorasTrabalhadas * valorHora;

            Console.WriteLine($@"NÚMERO = {numeroEmpregado}
SALÁRIO = U$ {salario.ToString("F2")}"
                );

            Console.ReadLine();
        }
    }
}
