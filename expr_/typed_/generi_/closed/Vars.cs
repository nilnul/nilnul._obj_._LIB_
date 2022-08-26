using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_.closed
{
	static public class _VarsX
	{
		static public nilnul.obj.expr_.typed_.generi_.var.Set<T> Vars<T>(this nilnul.obj.expr_.typed_.generi_.Closed<T> expr) {
			var v = new _vars.Visitor<T>();
			v.Visit(expr);
			return v.vars;
		}
	}
}
