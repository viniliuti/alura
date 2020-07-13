using System;

namespace _03_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaBruno = new ContaCorrente();

			contaBruno.Titular = "Bruno";

			Console.WriteLine(contaBruno.Saldo);

			bool resultadoSaque = contaBruno.Sacar(50);
			Console.WriteLine(contaBruno.Saldo);
			Console.WriteLine(resultadoSaque);

			 resultadoSaque = contaBruno.Sacar(500);
			Console.WriteLine(contaBruno.Saldo);
			Console.WriteLine(resultadoSaque);


		}
	}
}
