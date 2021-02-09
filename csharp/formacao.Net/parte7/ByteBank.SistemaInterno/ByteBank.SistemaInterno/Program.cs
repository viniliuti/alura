using System;
using System.Globalization;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaInterno
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente(1, 1);

			conta.Sacar(1);

			System.Console.WriteLine(conta.Saldo);

			UsingHumanizer();
		}

		static void UsingHumanizer()
		{
			DateTime dataFimPagamento = new DateTime(2020, 09, 22);
			DateTime dataCorrente = DateTime.Now;

			TimeSpan diferenca = dataFimPagamento - dataCorrente;

			System.Console.WriteLine(dataFimPagamento);
			System.Console.WriteLine(dataCorrente);
			System.Console.WriteLine($"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca, culture: new CultureInfo("pt-br"))}");
		}
	}
}
