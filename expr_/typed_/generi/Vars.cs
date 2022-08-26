using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr
{
	[Obsolete()]
	static public class _VarsX
	{
		static public nilnul.obj._expr.untyped_.var.Set Vars<T>(this nilnul.obj.ExprI_sys<T> expr) {
			var v = new _expr.untyped. _vars.lambda.Visitor();
			v.Visit(expr.untyped.ee.lambda);
			return v.vars;
		}
	}
}
