using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente(321, 123);

			System.Console.WriteLine(conta.Saldo);
		}
	}
}
