using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 10 - Calculando poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {

                valorInvestido *= 1.0036;

                Console.WriteLine($"Apos {contadorMes} mes voce terá: {valorInvestido.ToString("N2")}");

                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
