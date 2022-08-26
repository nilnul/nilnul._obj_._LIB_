using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped
{
	static public class _VarsX
	{
		static public nilnul.obj._expr.untyped_.var.Set _Vars_assumeNonlambda(this Expression expr) {
			var v = new _vars.lambda.Visitor();
			v.Visit(expr);
			return v.vars;
		}
		static public nilnul.obj._expr.untyped_.var.Set Vars(this Untyped expr) {
			return _Vars_assumeNonlambda(expr.ee);
		}
		static public nilnul.obj._expr.untyped_.var.Set Vars(this UntypedI expr) {
			return _Vars_assumeNonlambda(expr.lambda);
		}


	}
}
