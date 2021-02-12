using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
	public class ListaDeContaCorrente
	{
		private ContaCorrente[] _itens;
		private int _proximaPosicao;
		public int Tamanho { get { return _proximaPosicao; } }

		public ListaDeContaCorrente(int capacidadeInicial = 5)
		{
			_itens = new ContaCorrente[capacidadeInicial];
			_proximaPosicao = 0;
		}

		public void AddRange(params ContaCorrente[] contas)
		{
			foreach (var item in contas)
			{
				Adicionar(item);
			}
		}

		public void Adicionar(ContaCorrente item)
		{
			_itens[_proximaPosicao] = item;

			_proximaPosicao++;
			VerificarCapacidade(_proximaPosicao + 1);
		}

		private void VerificarCapacidade(int tamanhoNecessario)
		{
			if (_itens.Length >= tamanhoNecessario)
			{
				return;
			}

			int novoTamanho = _itens.Length * 2;

			novoTamanho = novoTamanho < tamanhoNecessario
				? tamanhoNecessario : novoTamanho;

			ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

			for (int index = 0; index < _itens.Length; index++)
			{
				novoArray[index] = _itens[index];
			}

			_itens = novoArray;
		}

		public void Remover(ContaCorrente item)
		{
			int indiceItem = -1;

			for (int i = 0; i < _proximaPosicao; i++)
			{
				if (_itens[i].Equals(item))
				{
					indiceItem = i;

					break;
				}
			}

			if (indiceItem == -1)
				return;

			for (int i = indiceItem; i < _proximaPosicao - 1; i++)
			{
				_itens[i] = _itens[i + 1];
			}

			_proximaPosicao--;
			_itens[_proximaPosicao] = null;
		}

		public ContaCorrente GetContaCorrenteIndice(int indice)
		{
			if (indice < 0 || indice >= _proximaPosicao)
				throw new ArgumentOutOfRangeException(nameof(indice));

			return _itens[indice];
		}

		public ContaCorrente this[int indice]
		{
			get { return GetContaCorrenteIndice(indice); }
		}

	}
}