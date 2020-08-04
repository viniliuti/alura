using System;
using System.IO;

namespace ByteBank
{
	public class LeitorDeArquivos : IDisposable
	{
		public string Arquivo { get; set; }

		public LeitorDeArquivos(string arquivo)
		{
			Arquivo = arquivo;

			// throw new FileNotFoundException();

			System.Console.WriteLine($"Abrindo arquivo: {arquivo}");
		}

		public string LerProximaLinha()
		{
			try
			{
				System.Console.WriteLine("Lendo linha . . . ");

				throw new IOException("Teste");

				return "Linha do arquivo";
			}
			catch (IOException)
			{
				throw;
			}
		}

		public void Dispose()
		{
			System.Console.WriteLine("Fechando arquivo.");
		}
	}
}