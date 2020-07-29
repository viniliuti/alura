namespace ByteBank
{
	[System.Serializable]
	public class SaldoInsuficienteException : System.Exception
	{
		public double Saldo { get; }
		public double ValorSaque { get; }

		public SaldoInsuficienteException() { }

		public SaldoInsuficienteException(double saldo, double valorSaque)
			: this($"Tentativa de saque no valor de: {valorSaque} em uma conta com saldo de: {saldo}")
		{
			Saldo = saldo;
			ValorSaque = valorSaque;

		}

		public SaldoInsuficienteException(string message) : base(message) { }

		// public SaldoInsuficienteException(string message, System.Exception inner) : base(message, inner) { }

		// protected SaldoInsuficienteException(
		// 	System.Runtime.Serialization.SerializationInfo info,
		// 	System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}