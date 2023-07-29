using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr_.substitute_
{


	public interface _ExprClosedI<in TVar, TExpr>
		:SubstituteI<TVar, TExpr,TExpr>
	{
	}

	[Obsolete()]
	public interface ExprClosedI<T, in TVar, TExpr>
		:_ExprClosedI<TVar, TExpr>
		where TVar: nilnul.obj.VarI5<T>
		where TExpr:nilnul.obj.ExprI3<T>

	{

	}


}
