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


			contaBruno.Depositar(500);
			Console.WriteLine(contaBruno.Saldo);

			ContaCorrente contaGabriela = new ContaCorrente();
			contaGabriela.Titular="Gabriela";

			bool transferencia = contaBruno.Transferir(200, contaGabriela);

			Console.WriteLine($"Conta do Bruno {contaBruno.Saldo}");
			Console.WriteLine($"Conta da Gabriela {contaGabriela.Saldo}");
			Console.WriteLine($"Resultado transferencia {transferencia}");


			transferencia = contaGabriela.Transferir(233, contaBruno);

			Console.WriteLine($"Conta do Bruno {contaBruno.Saldo}");
			Console.WriteLine($"Conta da Gabriela {contaGabriela.Saldo}");
			Console.WriteLine($"Resultado transferencia {transferencia}");


		}
	}
}
