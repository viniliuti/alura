using ByteBank.Modelos;
using System;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
	public class ListaDeContaCorrente
	{
		private ContaCorrente[] _itens;
		private int _proximaPosicao;

		public ListaDeContaCorrente(int capacidadeInicial = 5)
		{
			_itens = new ContaCorrente[capacidadeInicial];
			_proximaPosicao = 0;
		}

		public void Adicionar(ContaCorrente item)
		{
			System.Console.WriteLine($"Add item na posição {_proximaPosicao}");

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
	}
}