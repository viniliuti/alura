using System.Linq;
using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
	public class LeilaoRecebeOferta
	{
		[Theory]
		[InlineData(0, new double[] { })]
		[InlineData(2, new double[] { 800, 900 })]
		[InlineData(4, new double[] { 800, 900, 200, 500 })]
		public void NaoPermiteNovosLancesDadoLeilaoFinalizado(
			int qtdEsperada, double[] ofertas
		)
		{
			//Given
			var leilao = new Leilao("Van Gogh");
			var fulano = new Interessada("Fulano", leilao);

			foreach (var oferta in ofertas)
			{
				leilao.RecebeLance(fulano, oferta);
			}

			leilao.TerminaPregao();

			//When
			leilao.RecebeLance(fulano, 900);

			//Then
			var qtdObtida = leilao.Lances.Count();

			Assert.Equal(qtdEsperada, qtdObtida);
		}
	}
}