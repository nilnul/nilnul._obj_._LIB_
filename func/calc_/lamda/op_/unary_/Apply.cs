using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.calc_.lamda.op_.unary_
{
	static public class _ApplyX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="lambda">
		/// the body of this is an expr, not lambda anymore.
		/// </param>
		/// <param name="par"></param>
		/// <param name="expr"></param>
		/// <returns></returns>
		static public LambdaExpression Apply(
			LambdaExpression lambda, ParameterExpression par,  nilnul.obj.ExprI4 expr
		) {


			var pars = lambda.Parameters;
			if (pars.Contains(par) )
			{

				return LambdaExpression.Lambda(
					nilnul.obj.expr.var._SubstituteX.Substitute(
						lambda.Body
						,
						par
						,
						expr
					)
					,
					pars.Except( new[] { par } )
				);
			}

			// check inner lambda
			if (lambda.Body is LambdaExpression x)
			{
				return LambdaExpression.Lambda(
					Apply(x, par, expr)
					,
					lambda.Parameters
				);
			}


			return lambda;

		}

	}

}
