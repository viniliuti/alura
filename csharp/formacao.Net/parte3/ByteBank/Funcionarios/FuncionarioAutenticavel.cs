using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
	{
		public string Senha { get; set; }
		protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
		{
		}

		bool IAutenticavel.Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}