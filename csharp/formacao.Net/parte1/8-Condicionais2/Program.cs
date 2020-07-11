using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 8 - Condicionais 2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
