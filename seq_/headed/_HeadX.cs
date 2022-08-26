using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_.headed
{
	static public class _HeadX
	{
		static public T _Head<T>(this IEnumerable<T> headed) {
			return headed.First();
		}
	}
}
