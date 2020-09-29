using System;
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

			string url = "pagina?moedaOrigem=real&moedaDestino=dolar&valor=1500";
			ExtratorValorDeArgumentosURL valorURL = new ExtratorValorDeArgumentosURL(url);

			System.Console.WriteLine(valorURL.GetValor("moedaDestino"));
			System.Console.WriteLine(valorURL.GetValor("moedaOrigem"));
			System.Console.WriteLine(valorURL.GetValor("valor"));			
		}
	}
}
