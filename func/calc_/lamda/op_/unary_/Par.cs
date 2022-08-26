using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.calc_.lamda.op_.unary_
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
		static public LambdaExpression Uni( ParameterExpression par, LambdaExpression func) {
			return LambdaExpression.Lambda(
				func
				,
				par
			);
		}

		/// <summary>
		/// faltened.
		/// </summary>
		/// <param name="par"></param>
		/// <param name="func"></param>
		/// <returns></returns>
		static public LambdaExpression Rec( ParameterExpression par, LambdaExpression func) {
			return LambdaExpression.Lambda(
				func.Body
				,
				new[] {
					par
				}.Concat(
					func.Parameters
				)
			);
		}


		
	}
}
