using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial interface CompoI
	{

		void compo<TInVar, TInExpr, Func, Func1>
			(Func func, Func1 func1)
			where Func:ExprAsMemberI<TInExpr>
			where Func1:ApplyI<TInExpr>
			;


	}
}
