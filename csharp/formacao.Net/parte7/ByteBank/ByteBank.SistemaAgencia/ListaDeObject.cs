using System;

namespace ByteBank.SistemaAgencia
{
	public class ListaDeObject
	{
		private object[] _itens;
		private int _proximaPosicao;
		public int Tamanho { get { return _proximaPosicao; } }

		public ListaDeObject(int capacidadeInicial = 5)
		{
			_itens = new object[capacidadeInicial];
			_proximaPosicao = 0;
		}

		public void AddRange(params object[] itens)
		{
			foreach (var item in itens)
			{
				Adicionar(item);
			}
		}

		public void Adicionar(object item)
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

			object[] novoArray = new object[novoTamanho];

			for (int index = 0; index < _itens.Length; index++)
			{
				novoArray[index] = _itens[index];
			}

			_itens = novoArray;
		}

		public void Remover(object item)
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

		public object GetobjectIndice(int indice)
		{
			if (indice < 0 || indice >= _proximaPosicao)
				throw new ArgumentOutOfRangeException(nameof(indice));

			return _itens[indice];
		}

		public object this[int indice]
		{
			get { return GetobjectIndice(indice); }
		}

	}
}