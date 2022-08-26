using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuncI1 = nilnul.obj._func.FuncI_dynamic;
using Func = nilnul.obj._func.Func;
using V = nilnul.obj._var.VarI_dynamicTyped;

namespace nilnul.obj.func.op
{
	/// <summary>
	/// rename a bound par to a non-free par
	/// </summary>
	///
	[Obsolete()]
	public class RenameVar
	{
		static _func.FuncI_dynamic Eval(FuncI1 func, V var, V varNew) {

			return new Func(
				obj.var.set.Ordered.Rename( func.vars,var,varNew)
				,func.expr
			);

			throw new NotImplementedException();

		}
	}
}
