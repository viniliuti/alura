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
			int qtdEsperada, double[] ofertas)
		{
			//Given
			IModalidadeAvaliacao modalidade = new OfertaMaiorValor();
			var leilao = new Leilao("Van Gogh", modalidade);
			var fulano = new Interessada("Fulano", leilao);
			var ciclano = new Interessada("Ciclano", leilao);

			leilao.IniciaPregao();

			for (int i = 0; i < ofertas.Length; i++)
			{
				var oferta = ofertas[i];

				if (i % 2 == 0)
					leilao.RecebeLance(fulano, oferta);
				else
					leilao.RecebeLance(ciclano, oferta);
			}

			leilao.TerminaPregao();

			//When
			leilao.RecebeLance(fulano, 900);

			//Then
			var qtdObtida = leilao.Lances.Count();

			Assert.Equal(qtdEsperada, qtdObtida);
		}

		[Fact]
		public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
		{
			//Given
			IModalidadeAvaliacao modalidade = new OfertaMaiorValor();
			var leilao = new Leilao("Van Gogh", modalidade);
			var fulano = new Interessada("Fulano", leilao);

			leilao.IniciaPregao();

			leilao.RecebeLance(fulano, 100);

			//When
			leilao.RecebeLance(fulano, 900);

			//Then
			var qtdObtida = leilao.Lances.Count();
			var qtdEsperada = 1;

			Assert.Equal(qtdEsperada, qtdObtida);
		}

		[Theory]
		[InlineData(1200, 1250, new double[] { 800, 1150, 1400, 1250 })]
		public void RetornaValorSuperiorMaisProximoDadoLeilaoNessaModalidade(
			double valorDestino,
			double valorEsperado,
			double[] ofertas
		)
		{
			//Given
			IModalidadeAvaliacao modalidade = new OfertaSuperiorMaisProxima(valorDestino);

			var leilao = new Leilao("Van Gogh", modalidade);
			var fulano = new Interessada("Fulano", leilao);
			var ciclano = new Interessada("Ciclano", leilao);

			leilao.IniciaPregao();

			//When
			for (int i = 0; i < ofertas.Length; i++)
			{
				if (i % 2 == 0)
				{
					leilao.RecebeLance(fulano, ofertas[i]);
				}
				else
				{
					leilao.RecebeLance(ciclano, ofertas[i]);
				}
			}

			leilao.TerminaPregao();

			//Then
			var valorObtido = leilao.Ganhador.Valor;

			Assert.Equal(valorEsperado, valorObtido);
		}
	}
}