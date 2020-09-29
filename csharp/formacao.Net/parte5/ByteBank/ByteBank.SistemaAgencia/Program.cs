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

			string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
			ExtratorValorDeArgumentosURL valorURL = new ExtratorValorDeArgumentosURL(url);



			var argumentos = url.Split('?');

			var indiceInterrogacao = url.IndexOf('?');
			string substring = url.Substring(indiceInterrogacao + 1);

			// System.Console.WriteLine(indiceInterrogacao);
			// System.Console.WriteLine(substring);
			// System.Console.WriteLine(argumentos[1].ToString());
		}
	}
}
