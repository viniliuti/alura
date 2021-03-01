using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
	public static class ListExtensions<T>
	{
		public static void AddVarios(this List<T> list, params T[] arrItems)
		{
			foreach (T item in arrItems)
			{
				list.Add(item);
			}
		}
	}
}