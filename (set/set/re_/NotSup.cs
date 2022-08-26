using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{


	static public class _NotSupsetX


	{


		static public bool NotSupset<T>(this IEnumerable<T> a, IEnumerable<T> b
			,
			IEqualityComparer<T> elementEq
			)

		{

			return b.Any(x => ! a.Contains(x, elementEq));

		}


		static public bool NotSupset<T, TEq>(this IEnumerable<T> a, IEnumerable<T> b)
		where TEq : IEqualityComparer<T>, new()

		{

			return NotSupset(a,b, nilnul.obj_.Singleton<TEq>.Instance);

		}




	}
}

