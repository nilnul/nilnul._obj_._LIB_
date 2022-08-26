using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.op_.unary_
{
	public static  class _PrependX
	{
		static public IEnumerable<T> Prepend<T>(T ele, IEnumerable<T> seq) {
			return new[] { ele}.Concat(seq);
		}
	}
}
