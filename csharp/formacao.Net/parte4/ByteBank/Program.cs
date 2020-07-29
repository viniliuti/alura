using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ContaCorrente conta = new ContaCorrente(1, 2);

				conta.Depositar(50);
				System.Console.WriteLine(conta.Saldo);

				ContaCorrente conta2 = new ContaCorrente(123, 321);


				conta2.Transferir(-10, conta);

				System.Console.WriteLine(conta.Saldo);

				// Metodo();
			}
			catch (SaldoInsuficienteException ex)
			{
				System.Console.WriteLine($"Excecao do tipo saldo insuficiente exception. {ex.Message}");
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
