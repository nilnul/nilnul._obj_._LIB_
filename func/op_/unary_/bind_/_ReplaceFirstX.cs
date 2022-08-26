using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_.bind_
{
	static public class _ReplaceFirstX
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
		static public LambdaExpression _Apply_assumeFunc(
			LambdaExpression _assumeFunc,
			nilnul.obj.ExprI4 expr
		) {

			var pars = _assumeFunc.Parameters;
			if (pars.Any() )
			{

				return LambdaExpression.Lambda(
					nilnul.obj.expr.var._SubstituteX.Substitute(
						_assumeFunc.Body
						,
						pars.First()
						,
						expr
					)
					,
					pars.Skip(1)
				);
			}

			return _assumeFunc;

		}

		public  static LambdaExpression Lambda(FuncI3 par,ExprI4 boxed)
		{
			return _Apply_assumeFunc(par.flat.ee,boxed);
			//throw new NotImplementedException();
		}
		public  static Func3 Func(FuncI3 par,ExprI4 boxed)
		{
			return new obj.Func3(Lambda(par,boxed));
			//throw new NotImplementedException();
		}

	}

}
