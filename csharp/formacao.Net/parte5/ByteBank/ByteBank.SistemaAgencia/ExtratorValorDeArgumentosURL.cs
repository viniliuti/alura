using System;

namespace ByteBank.SistemaAgencia
{
	public class ExtratorValorDeArgumentosURL
	{
		private readonly string _argumentos;
		public string URL { get; }
		public ExtratorValorDeArgumentosURL(string url)
		{

			if (String.IsNullOrWhiteSpace(url))
				throw new ArgumentException(
					"O argumento url nao pode ser Null ou Vazia.",
					nameof(url));

			_argumentos = url.Substring(url.IndexOf('?') + 1);

			URL = url;
		}

		public string GetValor(string nomeParametro)
		{
			string termo = $"{nomeParametro}=";
			int indiceParametro = _argumentos.IndexOf(termo);

			string termoSubstring = _argumentos
				.Substring(indiceParametro + termo.Length);

			int indiceEComercial = termoSubstring.IndexOf('&');

			if (indiceEComercial > 0)
				return termoSubstring
					.Remove(indiceEComercial);

			return termoSubstring;
		}
	}
}