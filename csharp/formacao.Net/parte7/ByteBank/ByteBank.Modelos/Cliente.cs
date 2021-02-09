namespace ByteBank.Modelos
{
	public class Cliente
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Profissao { get; set; }

		public override bool Equals(object obj)
		{
			Cliente toCompare = obj as Cliente;

			if (toCompare == null)
				return false;

			if (toCompare.CPF == CPF)
				return true;

			return false;
		}
	}
}