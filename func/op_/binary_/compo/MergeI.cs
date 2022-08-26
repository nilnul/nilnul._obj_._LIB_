using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial interface MergeI<TInExpr>
	{
		public FuncI<TInVar> merge<TInVar1, TRet1, TInExpr1, TFunc>(
			TFunc func


		)
		where TFunc : FuncI<TInVar1, TRet1, TInExpr1>
		;


	}
}
