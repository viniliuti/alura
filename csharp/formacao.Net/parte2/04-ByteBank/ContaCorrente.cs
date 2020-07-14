namespace _04_ByteBank
{
	public class ContaCorrente
	{
		public Cliente Titular;
		public int Agencia;
		public int Numero;
		public double Saldo = 100;

		public bool Sacar(double valor)
		{
			if (Saldo < valor)
				return false;

			Saldo -= valor;
			return true;
		}

		public void Depositar(double valor) =>
			Saldo += valor;

		public bool Transferir(double valor, ContaCorrente contaDestino)
		{
			if (Saldo < valor)
				return false;

			Saldo -= valor;
			contaDestino.Depositar(valor);

			return true;
		}
	}
}