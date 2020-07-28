using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ContaCorrente conta = new ContaCorrente(0, 0);

				// Metodo();
			}
			catch (NullReferenceException e)
			{
				System.Console.WriteLine("Não é possivel dividir por zero " + e.Message);
			}
			catch (ArgumentException e)
			{
				System.Console.WriteLine($"Erro de ArgumentException {e.ParamName}");
				System.Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.Message);
				System.Console.WriteLine(e.StackTrace);
			}
		}

		private static void Metodo()
		{
			// TestaDivisao(20);
			TestaDivisao(0);
		}

		private static void TestaDivisao(int divisor)
		{
			int resultado = Dividir(10, divisor);
			System.Console.WriteLine($"Resultado divisao de 10 por: {divisor} é: {resultado}");

		}

		private static int Dividir(int numero, int divisor)
		{
			try
			{
				return numero / divisor;
			}
			catch (DivideByZeroException)
			{
				System.Console.WriteLine($"Exceção com numero: {numero} e divisor: {divisor}");

				throw;
			}
		}
	}
}
