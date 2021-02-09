using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			// ContaCorrente conta = new ContaCorrente(321, 123);

			// conta.Sacar(1);

			// System.Console.WriteLine(conta.Numero);

		}

		private static void GetObjectIsEqual()
		{
			Cliente cli1 = new Cliente()
			{
				Nome = "cli",
				CPF = "123",
				Profissao = "prof"
			};

			Cliente cli2 = new Cliente()
			{
				Nome = "cli",
				CPF = "123",
				Profissao = "prof"
			};

			ContaCorrente contaCorrente = new ContaCorrente(1, 2);

			System.Console.WriteLine(cli1.Equals(contaCorrente));
			System.Console.WriteLine(cli1.Equals(cli2));
		}

		private static void GetValueFromURL()
		{
			string url = "pagina?moedaOrigem=Real&moedaDestINo=doLar&valor=1500";
			ExtratorValorDeArgumentosURL valorURL = new ExtratorValorDeArgumentosURL(url);

			System.Console.WriteLine(valorURL.GetValor("moedaDestino"));
			System.Console.WriteLine(valorURL.GetValor("moedaOrigem"));
			System.Console.WriteLine(valorURL.GetValor("Valor"));
		}

		private static void GetPhoneNumber()
		{
			string padrao = "[0-9]{4,5}-*[0-9]{4}";

			string texto = "4587-9856 Meu nome é Vinicio, me ligue em 4587-9856";

			var bIsMatch = Regex.Match(texto, padrao);

			System.Console.WriteLine(bIsMatch);
		}
	}
}
