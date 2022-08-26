using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = System.Linq.Expressions.ParameterExpression;
using System.Linq.Expressions;

namespace nilnul.obj.func.op_.unary_
{
	/// <summary>
	/// </summary>
	///
	static public class _ReparX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_assumeFunc"></param>
		/// <param name="var"></param>
		/// <param name="_newPar_assumeOld0nonrep"></param>
		/// <returns></returns>
		static public LambdaExpression _LambdaReparred_lambdaAssumeFunc_newParAssumeOld0nonrep(this LambdaExpression _assumeFunc, V var, V _newPar_assumeOld0nonrep)
		{


			return _repar._NonrecurX._LambdaReparred_newParAssumeOld0nonrep(_assumeFunc,var,_newPar_assumeOld0nonrep);






		}
		static public LambdaExpression _LambdaReparred_lambdaAssumeFunc(this LambdaExpression func, V var, V varNew)
		{

			return _repar._NonrecurX.LambdaReparred(func, var, varNew);
		}

		static public LambdaExpression _LambdaReparred_lambdaAssumeFunc(this LambdaExpression func, V var, out V varNew)
		{

			return _repar._NonrecurX.LambdaReparred(func, var, out varNew);




		}

	}
}
