using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            // even if the result have decimal value
            // the division of INTs will not show it
            idade=15/2;

            Console.WriteLine(idade);

            // by adding .0 the result will be a Double
            idade=15.0/2;

            Console.WriteLine(idade);

            idade = 5/3;
            Console.WriteLine(idade);

            idade=5.0/3;
            Console.WriteLine(idade);
            Console.WriteLine(Convert.ToInt16(idade)); // by converting it back to INT the double value is Rounded to the closest INT

            Console.Read();
        }
    }
}
