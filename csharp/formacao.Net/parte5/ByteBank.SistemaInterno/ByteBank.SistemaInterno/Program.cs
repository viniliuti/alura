using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente(1, 1);

			conta.Sacar(1);

			System.Console.WriteLine(conta.Saldo);
		}
	}
}
