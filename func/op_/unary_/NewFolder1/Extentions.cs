using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.var.set.ordered;
using nilnul.obj.expr;

namespace nilnul.obj._func.func
{
	[Obsolete()]
	static public class Extentions
	{
		static public Func Rename(this Func func, _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew) {
			return Func.Rename(func, var, varNew);
		}
		static public Func Rename(this FuncI_dynamic func, _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew) {
			return     new Func(func.vars.Rename(var, varNew), func.expr.Substitute(var,  varNew))
			;
		}
		static public Func Reduce(this FuncI_dynamic func) {
			return     new Func(func.vars, func.expr.reduce())
			;
		}
	}
}
