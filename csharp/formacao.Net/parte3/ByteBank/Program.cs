using ByteBank.Sistemas;
using ByteBank.Funcionarios;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			UsarSistema();
		}

		public static void CalcularBonificacao()
		{
			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			Designer pedro = new Designer("111.123.456-99")
			{ Nome = "Pedro" };

			Diretor roberta = new Diretor("222.123.456-99")
			{ Nome = "Roberta" };

			Auxiliar igor = new Auxiliar("333.123.456-99")
			{ Nome = "Igor" };

			GerenteDeConta camila = new GerenteDeConta("444.123.456-99")
			{ Nome = "Camila" };

			Desenvolvedor guilherme = new Desenvolvedor("555.123.456-99")
			{ Nome = "Guilherme" };

			gerenciador.Registrar(pedro);
			gerenciador.Registrar(roberta);
			gerenciador.Registrar(igor);
			gerenciador.Registrar(camila);
			gerenciador.Registrar(guilherme);

			System.Console.WriteLine($"Total bonificacao mes: {gerenciador.TotalBonificacao}");
		}

		public static void UsarSistema()
		{
			var sistemaInterno = new SistemaInterno();

			Diretor roberta = new Diretor("111.123.456-99")
			{
				Nome = "Roberta",
				Senha = "123"
			};

			sistemaInterno.Logar(roberta, "123");

			GerenteDeConta camila = new GerenteDeConta("444.123.456-99")
			{
				Nome = "Camila",
				Senha = "111"
			};

			sistemaInterno.Logar(camila, "123");

			ParceiroComercial parceiro = new ParceiroComercial()
			{ Senha = "abc" };

			sistemaInterno.Logar(parceiro, "123");
		}
	}
}
