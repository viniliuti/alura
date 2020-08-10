namespace ByteBank.Modelos
{
	[System.Serializable]
	public class OperacaoFinanceiraException : System.Exception
	{
		public OperacaoFinanceiraException() { }
		public OperacaoFinanceiraException(string message) 
			: base(message) { }

		public OperacaoFinanceiraException(
			string message, 
			System.Exception inner
		) : base(message, inner) { }

	}
}