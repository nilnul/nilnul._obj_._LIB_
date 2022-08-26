using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	static public class _DisownX
	{
		static public bool Disown<T, TEq>(this IEnumerable<T> str, T x, TEq eq)
			where TEq : IEqualityComparer<T>
		{
			return !_HasX.Has(str,x,eq);
		}

	



		static public bool Disown<T, TEq>(this IEnumerable<T> str, T x)
			where TEq : IEqualityComparer<T>, new()
		{
			return !_HasX.Has<T,TEq>(str,x);
		}




	}
}
