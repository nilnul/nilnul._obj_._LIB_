using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.cast_
{
	static public class _DetipX
	{
		static public IEnumerable<T> _Detip_ofStarted<T>(this IEnumerable<T> started) {
			return started.Take(
				started.Count()-1
			);
		}
	}
}
