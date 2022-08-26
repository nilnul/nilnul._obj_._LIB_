using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	static public partial class MergeX<TInExpr>
	{

		/// <summary>
		/// merge func to func1 
		/// using func's first var, func1 remains unchanged.
		/// </summary>
		/// <typeparam name="TInVar"></typeparam>
		/// <typeparam name="TRet"></typeparam>
		/// <typeparam name="TFunc"></typeparam>
		/// <typeparam name="TInVar1"></typeparam>
		/// <typeparam name="TRet1"></typeparam>
		/// <typeparam name="TInExpr1"></typeparam>
		/// <typeparam name="TFunc1"></typeparam>
		/// <param name="func"></param>
		/// <param name="func1"></param>
		/// <returns></returns>
		static public FuncI<TInVar> Merge<TInVar, TRet, TRet_TInVar, TRet_Ret, TFunc, TInVar1, TRet1, TInExpr1, TFunc1>(
			TFunc func
			,
			TFunc1 func1
		)
		where TFunc :FuncI<TInVar,TRet>
		where TFunc1 : FuncI<TInVar1, TRet1, TInExpr1>
		where TRet : FuncI<TRet_TInVar,TRet_Ret>
		{
			return op.Param.Eval(
				(func as VarAsPropI<TInVar>).var
				,
				Merge(
					func.ret,
					
					func1
				)
			);
			throw new NotImplementedException();
		}



	}
}
