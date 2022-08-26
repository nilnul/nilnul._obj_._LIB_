using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func._stati
{

	public partial interface ExprAsMemberI_TInExpr<out TInExpr>
		:ExprAsMemberI<TInExpr, obj.expr.StatiI<TInExpr>>	
	{


	}


	
	public partial interface ExprAsMemberI<out TInExpr, out TExpr>
		:ExprAsMemberI<TExpr>
		where TExpr:obj.expr.StatiI<TInExpr>		
	{


	}

	public  interface ExprAsMemberI< out TExpr>
		
	{

		TExpr expr { get; }

	}

}
