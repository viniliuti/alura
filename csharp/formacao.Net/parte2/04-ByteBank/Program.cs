using System;

namespace _04_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			// Cliente gabriela = new Cliente();

			// gabriela.Nome = "Gabriela";
			// gabriela.Profissao = "Desenvolvedora C#";
			// gabriela.CPF = "123.321.213-99";

			ContaCorrente contaGabriela = new ContaCorrente();

			// contaGabriela.Titular = gabriela;
			contaGabriela.Titular = new Cliente()
			{
				Nome = "Gabriela",
				Profissao = "Desenvolvedora C#",
				CPF = "123.321.213-99"
			};
            
			contaGabriela.Depositar(500);
			contaGabriela.Agencia = 100;
			contaGabriela.Numero = 123988;

			Console.WriteLine(contaGabriela.Titular.Nome);

			// gabriela.Nome = "Gabrielaa";
			Console.WriteLine(contaGabriela.Titular.Nome);

		}
	}
}
