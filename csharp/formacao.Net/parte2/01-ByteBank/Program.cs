using System;

namespace _01_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaGabriela = new ContaCorrente();

			contaGabriela.Titular = "Gabriela";
			contaGabriela.Agencia = 863;
			contaGabriela.Numero = 836542;
			contaGabriela.Saldo = 100;

			Console.WriteLine(contaGabriela.Titular);
			Console.WriteLine($"Agencia: {contaGabriela.Agencia}");
			Console.WriteLine($"Numero: {contaGabriela.Numero}");
			Console.WriteLine($"Saldo: {contaGabriela.Saldo}");
			Console.ReadLine();

		}
	}
}
