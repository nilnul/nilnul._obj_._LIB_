using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_.headed
{
	static public class _TailX
	{
		static public IEnumerable<T> _Tail<T>(this IEnumerable<T> headed) {
			return headed.Skip(1);
		}
	}
}
