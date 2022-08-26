using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_
{
	static public class _NaryX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_expr_nonfunc">not func, let alone of lambda</param>
		/// <returns></returns>
		static public LambdaExpression _Lambda_assumeExpr(
			System.Linq.Expressions.Expression _expr_nonfunc
		) {
			return LambdaExpression.Lambda(_expr_nonfunc);
		}
		static public LambdaExpression Lambda(
			obj.ExprI4 expr
		) {
			return _Lambda_assumeExpr(expr.expr.ee);
		}

		static public LambdaExpression Lambda(
			obj.Expr4 expr
		) {
			return Lambda( (ExprI4)expr);
		}

		static public obj.Func3 Func(
			obj.ExprI4 expr
		) {
			return new Func3(
				Lambda(expr)
			);
		}



	}
}
