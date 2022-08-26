using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started.cast_
{
	static public class _RemoveLastNX
	{
		static public IEnumerable<T> RemoveLastN<T>(this IEnumerable<T> _objs__started, 
			uint i) {

			return _objs__started.Take(_objs__started.Count()-(int)i);
		}
	}
}
