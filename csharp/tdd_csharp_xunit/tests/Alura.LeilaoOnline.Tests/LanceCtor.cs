using Xunit;
using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.Tests
{
	public class LanceCtor
	{
		[Fact]
		public void LancaArgumentExceptionCasoValorNegativo()
		{
			//Given
			double valorNegativo = -100;

			//Then
			Assert.Throws<ArgumentException>(() =>
				//When
				new Lance(null, valorNegativo)
			);

			var valorEsperado = "Valor do lance deve ser igual ou maior que zero";
			//When
			var valorObtido = Assert.Throws<ArgumentException>(() =>
				new Lance(null, valorNegativo)
			);

			//Then
			Assert.Equal(valorEsperado, valorObtido.Message);
		}
	}
}