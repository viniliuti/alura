namespace _03_ByteBank
{
	public class ContaCorrente
	{
		public string Titular;
		public int Agencia;
		public int Numero;
		public double Saldo = 100;

		public bool Sacar(double valor)
		{
			if (Saldo < valor)
				return false;
			else
			{
				Saldo -= valor;
				return true;
			}
		}
	}
}