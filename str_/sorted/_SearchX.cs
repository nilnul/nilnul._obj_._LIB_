using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sorted
{
	/// <summary>
	/// 
	/// </summary>
	static public class _SearchX
	{
		static public (int?, int?) _BinarySearch_1sorted<T>(
			IComparer<T> comparer
			,
			List<T> nodes
			,
			T element
		)
		{

			var index = nodes.BinarySearch(element, comparer);

			//var order = new nilnul.order.ComparerAsOrder<T>(comparer);
			if (index >= 0)
			{
				return (
					index,
					index
				);
			}

			var indexComplement = ~index;
			if (indexComplement == nodes.Count)
			{
				return (indexComplement - 1, null);

			}
			if (indexComplement == 0)
			{
				return (null, 0);

			}

			return (indexComplement - 1, indexComplement);

		}
	}
}
