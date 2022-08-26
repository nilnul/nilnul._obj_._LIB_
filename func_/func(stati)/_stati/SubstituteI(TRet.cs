using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func._stati
{

	public  interface SubstituteI<out TFunc,  in TExpr>
		:SubstituteI<TFunc, obj.var.StatiI,TExpr>
	{



	}



	public  interface SubstituteI<out TFunc, in TVar, in TExpr>
	{

		TFunc substitute(TVar var, TExpr expr);


	}


}
