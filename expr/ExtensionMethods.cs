using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	static public class ExtensionMethods
	{
		static public _expr.ExprI_dynamic Substitute(this _expr.ExprI_dynamic expr, _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew) {

			return expr.substitute(var,
				new _expr.Var(
					varNew
				)
			);

		}

	}
}
