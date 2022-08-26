using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial interface CompoI<TInVar,TInExpr>
	{

		FuncI__Var_Expr<TInVar,  TInExpr_arg> compo<TInRet,TInExpr_arg>
			(FuncI<TInExpr,TInRet,TInExpr_arg> arg)
			
			;


	}
}
