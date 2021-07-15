using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
	public class LeilaoTerminaPregao
	{

		[Fact]
		public void RetornaZeroDadoLeilaoSemLances()
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
		public void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(
			double valorEsperado,
			double[] ofertas)
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