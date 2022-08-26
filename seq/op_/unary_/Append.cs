using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.convert_
{
	public static  class _AppendX
	{
		static public IEnumerable<T> Append<T>(IEnumerable<T> seq, T ele) {
			return seq.Concat(new[] { ele});
		}
	}
}
