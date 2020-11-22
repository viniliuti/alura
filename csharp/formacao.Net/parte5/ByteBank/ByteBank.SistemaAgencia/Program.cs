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


			GetPhoneNumber();
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
