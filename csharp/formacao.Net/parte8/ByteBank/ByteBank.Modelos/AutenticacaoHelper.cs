namespace ByteBank.Modelos
{
	class AutenticacaoHelper
	{
		public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
		{
			return senhaVerdadeira == senhaTentativa;
		}
	}
}