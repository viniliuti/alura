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

	}
}