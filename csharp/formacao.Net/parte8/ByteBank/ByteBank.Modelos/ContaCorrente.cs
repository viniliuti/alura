using System;

namespace ByteBank.Modelos
{
	/// <summary>
	/// Define uma Conta Corrente do banco ByteBank
	/// </summary>
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

		/// <summary>
		/// Cria uma instancia de Conta Corrente com os argumentos utilizados
		/// </summary>
		/// <param name="Agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero</param>
		/// <param name="Conta">Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que zero</param>
		public ContaCorrente(int Agencia, int Conta)
		{
			this.Agencia = Agencia <= 0 ?
				throw new ArgumentException("Agencia deve ser maior que Zero.", nameof(Agencia)) :
				Agencia;

			Numero = Conta <= 0 ?
				throw new ArgumentException("Numero deve ser maior que Zero.", nameof(Conta)) :
				Conta;

			TotalDeContasCriadas++;
			TaxaOperacao = 30 / TotalDeContasCriadas;
		}

		/// <summary>
		/// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
		/// </summary>
		/// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
		/// <exception cref="SaldoInsuficienteException">Exceção lançada quando um valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>. </exception>
		/// <param name="valor">Representa o valor do Saque, deve ser maior que 0(zero) e menor que o <see cref="Saldo"/>.</param>
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

		public override string ToString()
		{
			return $"Numero: {Numero}, Agencia: {Agencia}, Saldo: {Saldo}";
		}

		public override bool Equals(object obj)
		{
			ContaCorrente outraConta = obj as ContaCorrente;

			if (outraConta == null)
				return false;

			return Numero == outraConta.Numero
				&& Agencia == outraConta.Agencia;
		}
	}
}