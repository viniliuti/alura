using System;

namespace _02_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente();

			conta.Titular = "Gabriela";
			conta.Agencia = 863;
			conta.Numero = 863214;

			ContaCorrente contaGabrielaCosta = new ContaCorrente();

			conta.Titular = "Gabriela Costa";
			conta.Agencia = 863;
			conta.Numero = 863214;

			Console.WriteLine(conta == contaGabrielaCosta);

			conta = contaGabrielaCosta;


			Console.WriteLine(conta == contaGabrielaCosta);

			conta.Saldo = 300;

			Console.WriteLine(conta.Saldo);
			Console.WriteLine(contaGabrielaCosta.Saldo);

			if (contaGabrielaCosta.Saldo >= 100)
			{
				contaGabrielaCosta.Saldo -= 100;
			}

		}
	}
}
