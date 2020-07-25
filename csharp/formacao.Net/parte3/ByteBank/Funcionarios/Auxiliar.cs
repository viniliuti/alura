namespace ByteBank.Funcionarios
{
	public class Auxiliar : Funcionario
	{
		public Auxiliar(string cpf) : base(2000, cpf)
		{
		}

		public override double GetBonificacao()
		{
			return Salario * 0.2;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.1;
		}
	}
}