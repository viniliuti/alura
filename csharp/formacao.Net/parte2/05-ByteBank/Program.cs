using System;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente();
			conta.DefinirSaldo(-10);

			Console.WriteLine(conta.ObterSaldo());
		}
	}
}
