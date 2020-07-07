using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "Joao está acompanhado.";
            }
            else
            {
                mensagemAdicional = "Joao nao esta acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            aliquotaIfs();

            Console.ReadLine();
        }

        private static void aliquotaIfs()
        {
            double salario = 3300.0;

            if (salario >= 1900 && salario <= 2800)
                Console.WriteLine("Aliquota 7,5% com dedução até R$142.");
            else if (salario >= 2800.01 && salario <= 3751)
                Console.WriteLine("Aliquota 15% com dedução até R$350.");
            else if (salario >= 3751.01 && salario <= 4664)
                Console.WriteLine("Aliquota 22.5% com dedução até R$636");


        }
    }
}
