using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.op_.unary_
{
	public static  class _PrependX
	{
		static public IEnumerable<T> Prepend<T>(this IEnumerable<T> seq, T ele ) {
			return new[] { ele}.Concat(seq);
		}
	}
}
