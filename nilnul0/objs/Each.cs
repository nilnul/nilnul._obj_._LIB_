using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	static public class _EachX
	{
		static public void Each<T>(this IEnumerable<T> objs, Action<T> action) {
			foreach (T item in objs) action(item);

		}
	}
}
