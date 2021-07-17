using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.Core
{
	public enum EstadoLeilao
	{
		LeilaoAntesDoPregao,
		LeilaoEmAndamento,
		LeilaoFinalizado
	}

	public class Leilao
	{
		private IList<Lance> _lances;
		public IEnumerable<Lance> Lances => _lances;
		public string Peca { get; }
		public Lance Ganhador { get; set; }
		public EstadoLeilao Estado { get; private set; }
		public Interessada _ultimoCliente { get; private set; }


		public Leilao(string peca)
		{
			Peca = peca;
			_lances = new List<Lance>();
			Estado = EstadoLeilao.LeilaoAntesDoPregao;
		}

		private bool NovoLanceAceito(Interessada cliente, double valor)
		{
			return Estado == EstadoLeilao.LeilaoEmAndamento
				&& cliente != _ultimoCliente;
		}
		public void RecebeLance(Interessada cliente, double valor)
		{
			// if (Ganhador == null)
			if (NovoLanceAceito(cliente, valor))
			{
				_lances.Add(new Lance(cliente, valor));
				_ultimoCliente = cliente;
			}
		}
		public void IniciaPregao()
		{
			Estado = EstadoLeilao.LeilaoEmAndamento;
		}
		public void TerminaPregao()
		{
			Ganhador = Lances
				.DefaultIfEmpty(new Lance(null, 0))
				.OrderByDescending(o => o.Valor)
				.FirstOrDefault();

			Estado = EstadoLeilao.LeilaoFinalizado;
		}
	}
}