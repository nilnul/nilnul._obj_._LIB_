using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// don't use "Param" for "Param" is a reserved token
	static public class _ParX
	{
	

		/// <summary>
		/// faltened.
		/// </summary>
		/// <param name="par"></param>
		/// <param name="_assumeFunc">
		/// not a lambda, but a func, the body of which is an expr, not a func anymore.
		/// </param>
		/// <returns></returns>
		static public LambdaExpression _Lambda_lamdaAssumeFunc(
			ParameterExpression par
			,
			LambdaExpression _assumeFunc
		) {
			if (_assumeFunc.Parameters.Contains(par) )
			{
				throw new ArgumentException($"{par} is already in the pars list.");
			}
			return LambdaExpression.Lambda(
				_assumeFunc.Body
				,
				new[] {
					par
				}.Concat(
					_assumeFunc.Parameters
				)
			);
		}

		public static LambdaExpression Lambda(ParameterExpression boxed, FuncI3 par)
		{
			return _Lambda_lamdaAssumeFunc(boxed, par.flat);

			//throw new NotImplementedException();
		}
		public static Func3 Func(ParameterExpression boxed, FuncI3 par)
		{
			return new obj.Func3(Lambda(boxed,par) );
			//throw new NotImplementedException();
		}

	}
}
