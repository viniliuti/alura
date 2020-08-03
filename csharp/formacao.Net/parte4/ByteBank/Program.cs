using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ContaCorrente conta1 = new ContaCorrente(1, 2);
				ContaCorrente conta2 = new ContaCorrente(2, 3);

				conta1.Transferir(100000, conta2);
			}
			// catch (SaldoInsuficienteException ex)
			// {
			// 	System.Console.WriteLine($"Excecao do tipo saldo insuficiente exception. {ex.Message}");
			// 	System.Console.WriteLine(ex.Saldo);
			// 	System.Console.WriteLine(ex.ValorSaque);

			// 	System.Console.WriteLine(ex.StackTrace);
			// }
			catch (OperacaoFinanceiraException e)
			{
				System.Console.WriteLine(e.Message);
				System.Console.WriteLine(e.StackTrace);

				System.Console.WriteLine("inner");
				System.Console.WriteLine(e.InnerException.Message);
				System.Console.WriteLine(e.InnerException.StackTrace);
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
