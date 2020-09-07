using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente(321, 123);
			
			conta.Sacar(1);

			System.Console.WriteLine(conta.Numero);
		}
	}
}
