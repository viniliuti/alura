using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 13 - For encadeado");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    Console.Write('*');

                    if (contadorColuna >= contadorLinha)
                        break;
                }

                Console.WriteLine();

            }

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write('*');

                Console.WriteLine();

            }
            Console.WriteLine();

            escreveForNumeros();
            escreveTabuada();
            escreveMultiploTres();

            Console.ReadLine();
        }

        private static void escreveForNumeros()
        {
            for (int linha = 1; linha <= 5; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    Console.Write(coluna);
                }

                Console.WriteLine();
            }
        }

        private static void escreveTabuada()
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"{multiplicador}*{contador}={multiplicador * contador}");
                }

                Console.WriteLine();
            }
        }

        private static void escreveMultiploTres()
        {
            for (int i = 3; i < 100; i += 3)
            {
                // if (i % 3 == 0)
                Console.WriteLine($"{i} e multiplo de tres");
            }
        }
    }
}
