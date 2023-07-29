using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public class Unary<T>
		:
		obj.of_.OfSingle<T,T>,

		UnaryI<T>
		//,
		//op_.of_.VecI<T>

	{
		public Unary(Func<T, T> val) : base(val)
		{
		}

		public T op(IEnumerable<T> vec)
		{
			obj.vec_._str._VowX._VowArity(1, vec);
			return op(vec.First());
			//throw new NotImplementedException();
		}

		
	}

}
