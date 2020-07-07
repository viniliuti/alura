using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 11 - Calculando poupanca 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Apos {contadorMes} meses, voce terá: {valorInvestido}");
            }





            Console.ReadLine();
        }
    }
}
