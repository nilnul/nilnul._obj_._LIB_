using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public class Ternary<T> :
		nilnul.obj.Box1<Func<T,T,T,T> >
		,
		TernaryI<T>
		,
		op_.of_.VecI<T>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">made defaultable</param>
		public Ternary(Func<T, T, T,T> val) : base(val)
		{
		}

		public int arity =>3;

		public T op(T par, T par1,T par2)
		{
			return boxed(par,par1,par2);
			//throw new NotImplementedException();
		}

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
