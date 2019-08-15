using System;

namespace exercicio_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, trianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, pi;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            pi = 3.14159;

            trianguloRetangulo = a * c / 2 ;
            areaCirculo = pi * Math.Pow(c,2);
            areaTrapezio = ((a + b) / 2) * c;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine($"TRIÂNGULO: {trianguloRetangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");

            Console.ReadLine();
        }
    }
}
