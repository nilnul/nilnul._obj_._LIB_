using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Apply
	{
		static public FuncRet Eval<Func, FuncVar, FuncRet>(Func func, expr.ExprI<FuncVar> arg)
			where Func:RetI<FuncRet>, func.VarAsPropI<FuncVar>
			where FuncRet:SubstituteI
		{

			var r = func.ret;
			r.substitute(func.var, arg);

			return r;

		}



	}
}
