using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Metodo();
			}
			catch (NullReferenceException erro )
			{
				System.Console.WriteLine(erro.StackTrace);
				System.Console.WriteLine("Aconteceu um erro");
			}
		}

		private static void Metodo()
		{
			// TestaDivisao(20);
			TestaDivisao(0);
		}

		private static void TestaDivisao(int divisor)
		{
			try
			{
				int resultado = Dividir(10, divisor);
				System.Console.WriteLine($"Resultado divisao de 10 por: {divisor} é: {resultado}");
			}
			catch (DivideByZeroException erro)
			{
				System.Console.WriteLine(erro.Message);
				System.Console.WriteLine("Erro ao dividir por zero");
			}
		}

		private static int Dividir(int numero, int divisor)
		{
			ContaCorrente conta = null;
			System.Console.WriteLine(conta.Saldo);

			return numero / divisor;
		}
	}
}
