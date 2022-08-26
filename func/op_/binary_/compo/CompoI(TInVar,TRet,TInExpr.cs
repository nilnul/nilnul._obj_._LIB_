using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public abstract partial interface CompoI<TInVar,TInExpr>
	{

		FuncI<TInVar, TRet> compo<TRet_arg,TRet>(
			FuncI<TInExpr, TRet_arg> func
		);
			


	}
}
