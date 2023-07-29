using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{


	static public class _NotSubsetX


	{


		static public bool NotSubset<T>(
			this IEnumerable<T> a, IEnumerable<T> b
			,
			IEqualityComparer<T> elementEq
			)

		{

			return a.Any(x => ! b.Contains(x, elementEq));

		}


		static public bool NotSubset<T, TEq>(this IEnumerable<T> a, IEnumerable<T> b)
		where TEq : IEqualityComparer<T>, new()

		{

			return NotSubset(a,b, nilnul.obj_.Singleton<TEq>.Instance);

		}




	}
}

