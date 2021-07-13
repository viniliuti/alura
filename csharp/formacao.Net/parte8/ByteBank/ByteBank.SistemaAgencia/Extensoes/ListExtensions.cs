using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
	public static class ListExtensions
	{
		public static void AddVarios<T>(this List<T> list, params T[] arrItems)
		{
			foreach (T item in arrItems)
			{
				list.Add(item);
			}
		}
	}
}