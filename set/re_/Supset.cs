using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{

	/// <summary>
	/// a set is the supset of the other;
	/// </summary>
	/// alias:
	///		include

	static public class _SupsetX


	{


		static public bool Supset<T>(this IEnumerable<T> a, IEnumerable<T> b
			,
			IEqualityComparer<T> elementEq
			)

		{

			return b.All(x => a.Contains(x, elementEq));

		}


		static public bool Supset<T, TEq>(this IEnumerable<T> a, IEnumerable<T> b)
		where TEq : IEqualityComparer<T>, new()

		{

			return Supset(a,b, nilnul.obj_.Singleton<TEq>.Instance);

		}




	}
}

