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

namespace nilnul.obj._expr.untyped.var
{


	
	[Obsolete()]
	static public class SubstituteX
	{

		static public Untyped Substitute(this UntypedI x, obj._expr.untyped_.Var var, UntypedI y)
		{

			return new Untyped(new _substitute.lambda.Visitor(var, y.lambda.ee).Visit(x.lambda.ee));
		}

		
		static public Untyped Substitute(this UntypedI x, obj._expr.untyped_.Var var, Untyped y)
		{

			return Substitute(x,var, (UntypedI)y);
		}

		public static Untyped Substitute(this UntypedI expr, obj._expr.untyped_.Var var , Expression expression)
		{
			return Substitute(
				expr, var, new Untyped(expression)
			);
		}


		public static Untyped Substitute(
			this UntypedI expr,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				(

				expr)
				,
				new untyped_.Var(
				var
				)
				,
				(expression)
			);
		}

		public static Untyped Substitute(
			this Untyped expr,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				(UntypedI)(

				expr), var, (expression)
			);
		}

		public static Untyped Substitute(
			this Expression expr
			,
			ParameterExpression var
			,
			Expression expression
			)
		{
			return Substitute(
				new Untyped(

				expr), var, (expression)
			);
		}

		//public static Untyped Substitute(
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
