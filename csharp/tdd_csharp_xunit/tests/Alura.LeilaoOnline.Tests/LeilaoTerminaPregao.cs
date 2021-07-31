using System;
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
			IModalidadeAvaliacao modalidade = new OfertaMaiorValor();
			Leilao leilao = new Leilao("Barney", modalidade);

			leilao.IniciaPregao();

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


			// Act
			leilao.TerminaPregao();

			// Assert
			var valorObtido = leilao.Ganhador.Valor;

			Assert.Equal(valorEsperado, valorObtido);
		}

		[Fact]
		public void LancaInvalidOperationExceptionDadoPregaoNaoIniciado()
		{
			//Given
			IModalidadeAvaliacao modalidade = new OfertaMaiorValor();
			Leilao leilao = new Leilao("Barney", modalidade);

			// * could be just this \/
			//Assert.Throws<System.InvalidOperationException>(() =>
			// leilao.TerminaPregao());

			// * or 
			// * checking someting inside of the exception 
			// * like this \/
			var excecaoObtida = Assert.Throws<System.InvalidOperationException>(() =>
				leilao.TerminaPregao());

			var msgEsperada = "Não é possivel terminar pregao sem ter sido iniciado.";

			Assert.Equal(msgEsperada, excecaoObtida.Message);


			// * or even checkin the Exception as returned *TYPE*
			// try
			// {
			// 	//When
			// 	leilao.TerminaPregao();

			// 	Assert.True(false);
			// }
			// catch (System.Exception ex)
			// {
			// 	//Then
			// 	Assert.IsType<System.InvalidOperationException>(ex);
			// }
		}







	}
}