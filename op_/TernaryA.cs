using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public abstract class TernaryA<T> :
		
		TernaryI<T>
		,
		op_.of_.VecI<T>
	{
		

		public int arity =>3;

		public abstract T op(T par, T par1, T par2);

		public T op(IEnumerable<T> vec)
		{
			obj.vec_._str._VowX._VowArity(3, vec);
			return op(
				vec.First()
				,
				vec.ElementAt(1)
				,
				vec.Last()
			);
			//throw new NotImplementedException();
		}
	}


}
