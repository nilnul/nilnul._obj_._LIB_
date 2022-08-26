using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public class Unary<TRet,T>
		:
		nilnul.obj.Box1<Func<T, TRet>>

		,
		op_.OfI1<TRet,T>
		,
		op_.ITo<TRet,T>
		
	{
		public Unary(Func<T, TRet> val) : base(val)
		{
		}

		public int arity =>1;

		public TRet op(T par)
		{
			return boxed(par);
			//throw new NotImplementedException();
		}

	}
	public class Unary<T>
		:
		Unary<T,T>,

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
			throw new NotImplementedException();
		}

		
	}

}
