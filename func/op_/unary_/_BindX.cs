using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_
{
	static public class _ProvisionX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_assumeFunc">
		/// the body of this is an expr, not lambda anymore.
		/// </param>
		/// <param name="par"></param>
		/// <param name="expr"></param>
		/// <returns></returns>
		static public LambdaExpression _Bind_assumeFunc(
			LambdaExpression _assumeFunc, ParameterExpression par,  nilnul.obj.ExprI4 expr) {

			var pars = _assumeFunc.Parameters;
			if (pars.Contains(par) )
			{

				return LambdaExpression.Lambda(
					nilnul.obj.expr.var._SubstituteX.Substitute(
						_assumeFunc.Body
						,
						par
						,
						expr
					)
					,
					pars.Except( new[] { par } )
				);
			}

			return _assumeFunc;

		}

	}

}
