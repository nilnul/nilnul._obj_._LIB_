using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.op_.unary_
{
	static public class _TailX
	{
		static public IEnumerable<T> Enumable<T>(IEnumerable<T> x) {
			return x.Skip(1);
		}
	}
}
