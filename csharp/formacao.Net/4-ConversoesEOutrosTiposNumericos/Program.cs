using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 4 - Conversoes e outros tipos numericos");

            double salario = 1200.50;

            int salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
