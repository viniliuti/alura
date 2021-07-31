using System.Linq;

namespace Alura.LeilaoOnline.Core
{
	public class OfertaMaiorValor : IModalidadeAvaliacao
	{
		public Lance Avalia(Leilao leilao)
		{
			return
				leilao.Lances
				.DefaultIfEmpty(new Lance(null, 0))
				.OrderByDescending(o => o.Valor)
				.FirstOrDefault();
		}
	}
}