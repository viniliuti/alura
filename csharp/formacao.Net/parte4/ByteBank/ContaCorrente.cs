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
		public int ContadorSaquesNaoPermitidos { get; private set; }
		public int ContadorTransferenciasNaoPermitidos { get; private set; }


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

			TotalDeContasCriadas++;
			TaxaOperacao = 30 / TotalDeContasCriadas;
		}

		public void Sacar(double valor)
		{
			if (valor < 0)
				throw new ArgumentException("Valor invalido para o saque", nameof(valor));

			if (_saldo < valor)
			{
				ContadorSaquesNaoPermitidos++;

				throw new SaldoInsuficienteException(Saldo, valor);
			}

			_saldo -= valor;
		}

		public void Depositar(double valor) =>
			_saldo += valor;

		public void Transferir(double valor, ContaCorrente contaDestino)
		{
			if (valor < 0)
				throw new ArgumentException("Valor invalido para uma transferencia", nameof(valor));

			try
			{
				Sacar(valor);
			}
			catch (SaldoInsuficienteException ex)
			{
				ContadorTransferenciasNaoPermitidos++;

				throw new OperacaoFinanceiraException(
					"operacao nao realizada", 
					ex);
			}

			_saldo -= valor;
			contaDestino.Depositar(valor);
		}
	}
}