using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.var
{


	

	static public class _SubstituteX
	{
		static public Expr4 Substitute(this ExprI4 expr, obj.expr_.VarI var, ExprI4 newSubexpr)
		{

			return new Expr4(
				new _substitute.lambda.Visitor(var, newSubexpr.expr.ee).Visit(expr.expr.ee)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="expr"></param>
		/// <param name="var"></param>
		/// <param name="newSubexpr">
		/// the type may be incompatible with <paramref name="var"/>, resulting exception when compiled.
		/// </param>
		/// <returns>
		/// may result a type mismatch expression.
		/// </returns>
		static public Expr4 Substitute(this ExprI4 expr, obj.expr_.Var var, ExprI4 newSubexpr)
		{

			return new Expr4(
				new _substitute.lambda.Visitor(var, newSubexpr.expr.ee).Visit(expr.expr.ee)
			);
		}



		static public Expr4 Substitute(this ExprI4 x, obj.expr_.Var var, Expr4 y)
		{

			return Substitute(x,var, (ExprI4)y);
		}

		public static Expr4 Substitute(this ExprI4 expr, obj.expr_.Var var , Expression expression)
		{
			return Substitute(
				expr, var, new Expr4(expression)
			);
		}


		public static Expr4 Substitute(
			this ExprI4 expr,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				(

				expr)
				,
				new expr_.Var(
				var
				)
				,
				(expression)
			);
		}

		public static Expr4 Substitute(
			this Expr4 expr,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				(ExprI4)(

				expr), var, (expression)
			);
		}

		public static Expr4 Substitute(
			this Expression expr
			,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				new Expr4(

				expr), var, (expression)
			);
		}


		public static Expression Substitute(Expression body, ParameterExpression par, ExprI4 expr)
		{
			return Substitute(body, par, expr.expr);
		}

		//public static Expr4 Substitute(
		//	this Expression expr
		//	,
		//	ParameterExpression var
		//	,
		//	ParameterExpression expression
		//	)
		//{
		//	return Substitute(


		//		expr), var, (expression)
		//	);
		//}

	}
}
