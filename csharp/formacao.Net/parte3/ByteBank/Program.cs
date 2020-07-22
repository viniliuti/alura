using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			Funcionario carlos = new Funcionario();
			carlos.Nome = "Carlos";
			carlos.CPF = "123.321.123-99";
			carlos.Salario = 2000;

			gerenciador.Registrar(carlos);

			Console.WriteLine(carlos.Nome);
			Console.WriteLine(carlos.GetBonificacao());

			Diretor roberta = new Diretor();
			roberta.Nome = "Roberta";
			roberta.CPF = "412.141.228-78";
			roberta.Salario = 5000;

			Console.WriteLine(roberta.Nome);
			Console.WriteLine(roberta.GetBonificacao());
			gerenciador.Registrar(roberta);


			Console.WriteLine(gerenciador.TotalBonificacao);
		}
	}
}
