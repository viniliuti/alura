using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
	public class SistemaInterno
	{
		public bool Logar(IAutenticavel funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if (usuarioAutenticado)
			{
				System.Console.WriteLine("Seja bem vindo(a) ao sistema");
				return true;
			}

			System.Console.WriteLine("Esta senha esta incorreta");
			return false;
		}
	}
}