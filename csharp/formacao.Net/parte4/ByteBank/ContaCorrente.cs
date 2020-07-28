using System;

namespace ByteBank
{
	public class ContaCorrente
	{
		public Cliente Titular { get; set; }

		public static double TaxaOperacao { get; private set; }
		public static int TotalDeContasCriadas { get; private set; }

		public int Numero { get; }

		public int Agencia { get; }


		private double _saldo = 100;

		public double Saldo //= 100
		{
			get
			{
				return _saldo;
			}
			set
			{
				if (value > 0)
					this._saldo = value;
			}
		}

		public ContaCorrente(int numeroAgencia, int numeroConta)
		{
			Agencia = numeroAgencia <= 0 ?
				throw new ArgumentException("Agencia deve ser maior que Zero.", nameof(numeroAgencia)) :
				numeroAgencia;

			Numero = numeroConta <= 0 ?
				throw new ArgumentException("Numero deve ser maior que Zero.", nameof(numeroConta)) :
				numeroConta;

			TaxaOperacao = 30 / TotalDeContasCriadas;

			TotalDeContasCriadas++;
		}

		public bool Sacar(double valor)
		{
			if (_saldo < valor)
				return false;

			_saldo -= valor;
			return true;
		}

		public void Depositar(double valor) =>
			_saldo += valor;

		public bool Transferir(double valor, ContaCorrente contaDestino)
		{
			if (_saldo < valor)
				return false;

			_saldo -= valor;
			contaDestino.Depositar(valor);

			return true;
		}
	}
}