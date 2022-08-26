using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed
{
	[Obsolete(nameof(obj.expr_.typed_.generi_.closed._VarsX))]
	static public class _VarsX
	{
		static public nilnul.obj.expr_.var.Set<T> Vars<T>(this nilnul.obj.expr_.Closed1<T> expr) {
			var v = new _vars.Visitor<T>();
			v.Visit(expr);
			return v.vars;
		}
	}
}
