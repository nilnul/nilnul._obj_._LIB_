using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType.expr.rel
{
	static public partial class IsSubTypeOfX
	{
		static public bool Eval(this withType.expr.ExprI sub,withType.expr.ExprI sup) {
			return IsSupTypeOfX.Eval(sup,sub);
		}
	}
}
