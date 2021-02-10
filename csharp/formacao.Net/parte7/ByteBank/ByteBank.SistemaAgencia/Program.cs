using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente[] contas = new ContaCorrente[]
			{
				new ContaCorrente(845, 654321),
				new ContaCorrente(845, 654322),
				new ContaCorrente(845, 654323)
			};

			for (int i = 0; i < contas.Length; i++)
			{
				System.Console.WriteLine($"Conta {i} {contas[i].Numero}");
			}
		}

		static void TestaArrayInt()
		{
			int[] idades = new int[3];

			idades[0] = 15;
			idades[1] = 30;
			idades[2] = 45;
			// idades[3] = 60;
			// idades[4] = 75;

			int acumulador = 0;

			for (int index = 0; index < idades.Length; index++)
			{
				acumulador += idades[index];
			}

			int media = acumulador / idades.Length;

			System.Console.WriteLine($"Media de idades = {media}");
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
