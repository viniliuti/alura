using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
	public class LeilaoTestes
	{
		[Fact]
		private void LeilaoComVariosLances()
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


			Assert.Equal(valorEsperado, valorObtido);
		}
		[Fact]
		public void LeilaoComApenasUmLance()
		{
			// Arrange
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);

			leilao.RecebeLance(fulano, 800);

			// Act
			leilao.TerminaPregao();

			// Assert
			int valorEsperado = 800;
			var valorObtido = leilao.Ganhador.Valor;

			Assert.Equal(valorEsperado, valorObtido);
		}

		[Fact]
		public void LeilaoComLancesOrdenadosPorValor()
		{
			//Given
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);
			var maria = new Interessada("Maria", leilao);

			leilao.RecebeLance(fulano, 800);
			leilao.RecebeLance(maria, 900);
			leilao.RecebeLance(maria, 990);
			leilao.RecebeLance(fulano, 1000);

			//When
			leilao.TerminaPregao();

			//Then
			int valorEsperado = 1000;
			var valorObtido = leilao.Ganhador.Valor;


			Assert.Equal(valorEsperado, valorObtido);
		}

		[Fact]
		public void LeilaoComTresCliente()
		{
			//Given
			//Leilao com 3 clientes e lances realizados por eles
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);
			var maria = new Interessada("Maria", leilao);
			var beltrano = new Interessada("Beltrano", leilao);

			leilao.RecebeLance(fulano, 800);
			leilao.RecebeLance(maria, 900);
			leilao.RecebeLance(maria, 990);
			leilao.RecebeLance(fulano, 1000);
			leilao.RecebeLance(beltrano, 1400);

			//When
			//Quando o leilao/pregao termina
			leilao.TerminaPregao();

			//Then
			//Entao o valor esperado é o maior valor dado pelo cliente
			//E o cliente ganhador é o que deu maior lance
			int valorEsperado = 1400;
			var valorObtido = leilao.Ganhador.Valor;

			Assert.Equal(valorEsperado, valorObtido);
			Assert.Equal(beltrano, leilao.Ganhador.Cliente);
		}

		[Fact]
		public void LeilaoSemLance()
		{
			//Given
			Leilao leilao = new Leilao("Barney");

			//When
			leilao.TerminaPregao();

			//Then
			Assert.Equal(0, leilao.Ganhador.Valor);
		}

		[Theory]
		[InlineData(1000, new double[] { 800, 900, 1000, 990 })]
		[InlineData(1400, new double[] { 800, 900, 1000, 1400 })]
		[InlineData(800, new double[] { 800 })]
		public void LeilaoComPeloMenosUmLance(double valorEsperado, double[] ofertas)
		{
			// Arrange
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);

			foreach (var oferta in ofertas)
			{
				leilao.RecebeLance(fulano, oferta);
			}

			// Act
			leilao.TerminaPregao();

			// Assert
			var valorObtido = leilao.Ganhador.Valor;

			Assert.Equal(valorEsperado, valorObtido);
		}
	}
}