using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_
{
	static public class _NoneX
	{
		static public bool None<T>(this IEnumerable<T> seq) {
			return !seq.Any();
		}

		static public bool None<T>(this IEnumerable<T> seq, System.Func<T, bool> predicate) {
			return !seq.Any(predicate);
		}

	}
}
