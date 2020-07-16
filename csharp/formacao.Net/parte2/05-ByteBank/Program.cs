using System;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente();

			// conta.SetSaldo(-10);
			conta.Saldo = -10;

			Console.WriteLine(conta.Saldo);

			conta.Depositar(10);

			Console.WriteLine(conta.Saldo);


			Cliente cliente = new Cliente();
			cliente.CPF = "123";
			cliente.Nome = "Sim";

			conta.Titular = cliente;

			Console.WriteLine(conta.Titular.Nome);
		}
	}
}
