using System;

namespace nilnul.obj.op_
{
	[Obsolete(nameof(obj.of_.OfSingle<TRet,T>))]
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

}
