using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq
{
	static public class Extensions
	{
		static public bool None<T>(this IEnumerable<T> seq) {
			return !seq.Any();
		}

		static public IEnumerable<T> Skip<T>(this IEnumerable<T> seq) {
			return seq.Skip(1);
		}

	}
}
