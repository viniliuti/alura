using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos
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