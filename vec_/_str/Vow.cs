using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec_._str
{
	static public class _VowX
	{
		static public void _VowArity<T>(int _arity, IEnumerable<T> vec)
		{
			if (vec.Count() != _arity)
			{
				throw new vec_.str_.ArityException(_arity,vec);
			}
		}
	}
}
