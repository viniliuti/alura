using ByteBank.Funcionarios;

namespace ByteBank
{
	public class GerenciadorBonificacao
	{
		public double TotalBonificacao {get; private set;}

		public void Registrar(Funcionario funcionario)
		{
			TotalBonificacao += funcionario.GetBonificacao();
		}
	}
}