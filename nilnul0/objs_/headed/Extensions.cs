using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.headed
{
	static public class ExtensionsX
	{
		static public IEnumerable<T> AsSeq<T>(this (T, IEnumerable<T> ) headed  ) {
			yield return headed.Item1;
			foreach (var item in headed.Item2)
			{
				yield return item;

			}
		}
	}
}
