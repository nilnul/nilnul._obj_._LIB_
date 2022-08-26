using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.sortie
{
	static public class _FindX
	{

		static public (int?, int?) _IndexRange<T>(List<T> _list_sortie, T el, IComparer<T> comparer)
		{
			var index = _list_sortie.BinarySearch(el, comparer);
			if (index >= 0)
			{
				return (
					 index, index
				);
			}

			var largerIndex = ~index;

			if (largerIndex >= _list_sortie.Count)
			{
				return (_list_sortie.Count - 1, null);
			}
			if (largerIndex == 0)
			{
				return (null, 0);
			}
			return (largerIndex - 1, largerIndex);
		}

		static public (int?, int?) _IndexRange<T>(IEnumerable<T> _list_sortie, T el, IComparer<T> comparer)
		{
			int? lowerIndex=null;
			
			var enumerator = _list_sortie.GetEnumerator();

			var pointer = 0;
			while (enumerator.MoveNext())
			{
				var compared = comparer.Compare(enumerator.Current, el);


				if (compared < 0)
				{
					lowerIndex = pointer;
				}
				else if (
				   compared == 0
				   ) {
					return (pointer, pointer);
				}
				else
				{
					return (lowerIndex,pointer);
				}
				pointer++;


			}

			return ( lowerIndex, null);

		}


	}
}
