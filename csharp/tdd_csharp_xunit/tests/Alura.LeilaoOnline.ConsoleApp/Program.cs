using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			LeilaoComVariosLances();
			LeilaoComApenasUmLance();
		}
		private static void Verifica(double esperado, double obtido)
		{
			var color = Console.ForegroundColor;

			if (esperado == obtido)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				System.Console.WriteLine("Teste OK");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				System.Console.WriteLine($"Teste FALHOU. Esperado:{esperado}, Obtido:{obtido}");
			}
		}
		private static void LeilaoComVariosLances()
		{
			// Arrange
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);
			var maria = new Interessada("Maria", leilao);

			leilao.RecebeLance(fulano, 800);
			leilao.RecebeLance(maria, 900);
			leilao.RecebeLance(fulano, 1000);
			leilao.RecebeLance(maria, 990);

			// Act
			leilao.TerminaPregao();

			// Assert
			int valorEsperado = 1000;
			var valorObtido = leilao.Ganhador.Valor;

			Verifica(valorEsperado, valorObtido);
		}
		private static void LeilaoComApenasUmLance()
		{
			// Arrange
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);

			leilao.RecebeLance(fulano, 800);

			// Act
			leilao.TerminaPregao();

			// Assert
			int valorEsperado = 810;
			var valorObtido = leilao.Ganhador.Valor;

			Verifica(valorEsperado, valorObtido);
		}

	}
}
