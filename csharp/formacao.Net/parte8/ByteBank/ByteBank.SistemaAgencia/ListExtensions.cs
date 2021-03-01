using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
	public static class ListExtensions
	{
		public static void AddVarios(this List<T> list, params T[] itens)
		{
			foreach (var item in itens)
			{
				list.Add(item);
			}
		}
	}
}