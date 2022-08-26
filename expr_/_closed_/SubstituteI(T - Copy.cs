using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr_._closed_
{
	
	public interface SubstituteI<T, in TVar, TExpr>
		:
		
		nilnul.obj._expr_.SubstituteI<TVar, TExpr,TExpr>
		where TVar: nilnul.obj.VarI6<T>
		where TExpr: nilnul.obj.expr_.IClosed<T>

	{ }


	

	public interface SubstituteI<in TVar, TExpr>
		:
		
		nilnul.obj._expr_.SubstituteI<TVar, TExpr,TExpr>
	{
	}


	



}
