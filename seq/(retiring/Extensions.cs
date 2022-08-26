using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.seq
{
	[Obsolete("nilnul.seq should be reserved for library where seq is specially researched; whileas here we only study obj and seq is a structure derived from obj")]
	static public class Extensions
	{
		static public bool None<T>(this IEnumerable<T> seq) {
			return !seq.Any();
		}
	}
}
