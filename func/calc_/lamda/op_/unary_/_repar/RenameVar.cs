using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = System.Linq.Expressions.ParameterExpression;
using System.Linq.Expressions;

namespace nilnul.obj.func.calc_.lamda.op_.unary_._repar
{
	/// <summary>
	/// 
	/// apply and then abstract
	/// 
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	///
	static public class _ReparX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="func"></param>
		/// <param name="var"></param>
		/// <param name="varNew"></param>
		/// <returns></returns>
		static public LambdaExpression _Rename_assumeNewCompatible(LambdaExpression func, V var, V varNew)
		{


			return LambdaExpression.Lambda(
				func.Body
				,
				func.Parameters.Select(
					p => p == var ? varNew : p
				)

			);






		}
		static public LambdaExpression Rename(LambdaExpression func, V var, V varNew)
		{

			if (var == varNew)
			{
				return func;
			}
			if (func.Parameters.Contains(varNew))
			{
				throw new Exception(" newPar shall not be conflicting with other pars");
			}

			var vars = nilnul.obj.expr._VarsX1._Exprs_assumeExpr(func.Body);

			if (vars.has(varNew))
			{
				throw new Exception(" newPar shall not be bounded");


			}

			if (func.Parameters.Contains(var))
			{
				if (var.Type.IsAssignableFrom(varNew.Type))
				{
					return _Rename_assumeNewCompatible(func, var, varNew);

				}
				throw new Exception(
					$"newVar shall be a compatible type of oldVar"
				);

			}

			return func;
		}

		static public LambdaExpression Rename(this LambdaExpression func, V var, out V varNew)
		{

			varNew = Expression.Parameter(
				var.Type
			);

			return _Rename_assumeNewCompatible(func, var, varNew);




		}

	}
}
