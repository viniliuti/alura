namespace ByteBank.Modelos.Funcionarios
{
	public class Designer : Funcionario
	{
		public Designer(string cpf) : base(3000, cpf)
		{
		}

		internal protected override double GetBonificacao()
		{
			return Salario * 0.17;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.11;
		}
	}
}