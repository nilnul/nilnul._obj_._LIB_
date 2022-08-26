using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	/// <summary>
	/// replace the "ret" with a new FuncI(var, ret)
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	public partial interface ExprReplaceI1<TInVar,TRet,TInExpr>
	{

		FuncI<
			TInVar
			,
			ExprReplacedI<TInVar,TRet,TInExpr,TInNewExpr>
		> exprReplace<TInNewExpr>(
			obj.expr.ExprI<TInNewExpr> expr
		);


	}
	/// <summary>
	/// represents the func type when FuncI(TInVar,TRet) is exprReplaced by obj.expr.ExprI(TInNewExpr).
	/// </summary>
	/// <typeparam name="TInVar"></typeparam>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TInNewExpr"></typeparam>
	/// <remarks>
	/// Func(TInVar,TRet, TInExpr) : ExprReplacedI(TInVar,TRet,TRet)
	///		where TRet: ExprI(TInExpr)
	/// </remarks>

	public partial interface ExprReplacedI<TInVar, TRet, TInExpr, TInNewExpr> { 
	
	}
}
