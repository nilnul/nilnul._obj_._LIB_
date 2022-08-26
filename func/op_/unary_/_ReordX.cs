using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = System.Linq.Expressions.ParameterExpression;
using System.Linq.Expressions;

namespace nilnul.obj.func.op_.unary_
{
	/// <summary>
	/// re-order the pars. we can move the par to the head to replace.
	/// </summary>
	///
	static public class _ReordX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_assumeFunc"></param>
		/// <param name="var"></param>
		/// <param name="_newPar_assumeOld0nonrep"></param>
		/// <returns></returns>
		static public LambdaExpression _LambdaReorded_lambdaAssumeFunc_indexAssumeNonneg(this LambdaExpression _assumeFunc, int _newPar_assumeOld0nonrep)
		{
			if (_newPar_assumeOld0nonrep >= _assumeFunc.Parameters.Count)
			{
				return _assumeFunc;
			}

			var newPars = new List<ParameterExpression>(
				_assumeFunc.Parameters
			);

			var t = _assumeFunc.Parameters[_newPar_assumeOld0nonrep];

			newPars.RemoveAt(_newPar_assumeOld0nonrep);
			newPars.Insert(0, t);

			return LambdaExpression.Lambda(
				_assumeFunc.Body
				,
				newPars
			);
		}
	

	}
}
