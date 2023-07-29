using System;

namespace nilnul.obj.of_
{
	public class OfSingle< TRet,T>
		:
		nilnul.obj.Box1<Func<T, TRet>>
		,
		of_.OfSingleI<TRet,T>

		////,

		////op_.OfI1<TRet,T>
		//,
		//op_.ITo<TRet,T>
		
	{
		public OfSingle(Func<T, TRet> val) : base(val)
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
