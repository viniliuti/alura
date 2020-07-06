using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 6 - Atribuicoes de variaveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            pointerTest(idade);


            Console.ReadLine();
        }

        // I though the pointer would store de value but in fact it stores the memory location
        // this is only available on a Unsafe mode defined on the csproj
        
        unsafe static void pointerTest(int idade)
        {
            int* pointerIdade = &idade;

            int idadePointerValue = (int)pointerIdade;

            Console.WriteLine(idadePointerValue);

            idade = idade + 5;
            idadePointerValue = (int)pointerIdade;
            Console.WriteLine(idadePointerValue);
        }
    }
}
