using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started.cast_
{
	static public class _RemoveLastX
	{
		static public IEnumerable<T> RemoveLast<T>(this IEnumerable<T> _objs__started) {

			return _objs__started.Take(_objs__started.Count()-1);
		}
	}
}
