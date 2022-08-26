using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable.convert_
{
	static public class _AdjacenciesX
	{
		static public IEnumerable<Tuple<T, T>> _Adjacencies<T>(IEnumerable<T> _str)
		{
			var enumerator = _str.GetEnumerator();

			if (enumerator.MoveNext())
			{
				var current = enumerator.Current;

				while (enumerator.MoveNext())
				{

					yield return new Tuple<T, T>(current, enumerator.Current);

					current = enumerator.Current;



				}

			}



		}
	}


}
