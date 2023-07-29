using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{
	[Obsolete(nameof(obj.op_.TernaryA<T>))]
	public abstract class TernaryA<T> :
		
		TernaryI<T>
		,
		of_.vec_.ScalaI<T>
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
