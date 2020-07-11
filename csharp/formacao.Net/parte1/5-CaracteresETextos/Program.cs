using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura";
            Console.WriteLine(titulo);

            titulo = titulo + 2020;
            Console.WriteLine(titulo);

            string cursos = " - .Net " +
            " - Java" +
            " - Javascript";
            Console.WriteLine(cursos);

            cursos= @" - .Net
            - Java
            - Javascript";
            Console.WriteLine(cursos);

            cursos = 
            @"- .Net
- Java
- Javascript";
            Console.WriteLine(cursos);

            Console.ReadLine();
        }
    }
}
