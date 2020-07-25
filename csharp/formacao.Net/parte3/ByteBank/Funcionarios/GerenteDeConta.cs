using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
	public class GerenteDeConta : FuncionarioAutenticavel
	{
		public GerenteDeConta(string cpf) : base(4000, cpf)
		{
		}

		public override double GetBonificacao()
		{
			return Salario * 0.25;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.05;
		}
	}
}