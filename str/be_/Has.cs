using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	static public class _HasX
	{
		static public bool Has<T, TEq>(this IEnumerable<T> str, T x, TEq eq)
			where TEq : IEqualityComparer<T>
		{
			return str.Contains(x, eq);
		}
		static public bool Has<T, TEq>(this IEnumerable<T> str, T x)
			where TEq : IEqualityComparer<T>, new()
		{
			return str.Has(x, SingletonByDefault<TEq>.Instance);
		}
	}

	
}
