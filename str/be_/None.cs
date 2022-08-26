using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	static public class _NoneX
	{
		static public bool None<T>(this IEnumerable<T> str, System.Func<T, bool> func)
		{
			return !str.Any(x => func(x));
		}

		static public bool None<T>(this IEnumerable<T> str)
		{
			return !str.Any();
		}
	}
}