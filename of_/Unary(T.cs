using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{

	public class Unary<T>
		:
		op_.Unary<T,T>,

		UnaryI<T>
		,
		op_.of_.VecI<T>

	{
		public Unary(Func<T, T> val) : base(val)
		{
		}

		public T op(IEnumerable<T> vec)
		{
			obj.vec_._str._VowX._VowArity(1, vec);
			return op(vec.First());
		}

		
	}

}
