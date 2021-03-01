namespace ByteBank.Modelos.Funcionarios
{
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
	{
		public string Senha { get; set; }
		private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

		protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
		{
		}

		bool IAutenticavel.Autenticar(string senha)
		{
			return _autenticacaoHelper.CompararSenhas(Senha, senha);
		}
	}
}