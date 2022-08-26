using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr_
{
	public interface ISubstitute {

	}

	public  interface SubstituteI< in TVar, in TVal, out TRet >
	{
		TRet substitute( TVar var, TVal expr);

	}


	//[Obsolete()]
	public  interface SubstituteI<T, in TVar, in TVal, out TRet>
		:SubstituteI<TVar,TVal, TRet>

		where TVar:nilnul.obj.VarI5<T>
		where TVal:nilnul.obj.ExprI3<T>
		
	{
 
	}

	[Obsolete(nameof(substitute_._ExprClosedI<TVar,TExpr>))]
	public interface SubstituteI<in TVar, TExpr>
		:SubstituteI<TVar, TExpr,TExpr>
	{ }


	



}
