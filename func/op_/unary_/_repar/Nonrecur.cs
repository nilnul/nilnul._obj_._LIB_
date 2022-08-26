using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = System.Linq.Expressions.ParameterExpression;
using System.Linq.Expressions;

namespace nilnul.obj.func.op_.unary_._repar
{
	/// <summary>
	/// </summary>
	///
	static public class _NonrecurX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_assumeFunc"></param>
		/// <param name="var"></param>
		/// <param name="_newPar_assumeOld0nonrep"></param>
		/// <returns></returns>
		static public LambdaExpression _LambdaReparred_newParAssumeOld0nonrep(LambdaExpression _assumeFunc, V var, V _newPar_assumeOld0nonrep)
		{


			return LambdaExpression.Lambda(
				_assumeFunc.Body
				,
				_assumeFunc.Parameters.Select(
					p => p == var ? _newPar_assumeOld0nonrep : p
				)

			);






		}
		static public LambdaExpression LambdaReparred(LambdaExpression func, V var, V varNew)
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
					return _LambdaReparred_newParAssumeOld0nonrep(func, var, varNew);

				}
				throw new Exception(
					$"newVar shall be a compatible type of oldVar"
				);

			}

			return func;
		}

		static public LambdaExpression LambdaReparred(this LambdaExpression func, V var, out V varNew)
		{

			varNew = Expression.Parameter(
				var.Type
			);

			return _LambdaReparred_newParAssumeOld0nonrep(func, var, varNew);




		}

	}
}
