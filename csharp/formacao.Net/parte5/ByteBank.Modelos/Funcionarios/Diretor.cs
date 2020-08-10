namespace ByteBank.Modelos.Funcionarios
{
	public class Diretor : FuncionarioAutenticavel
	{
		public Diretor(string cpf) : base(5000, cpf)
		{
		}

		public override double GetBonificacao()
		{
			return Salario * 0.5;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.15;
		}
	}
}