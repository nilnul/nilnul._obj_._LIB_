using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType.rel
{
	static public partial class IsSubTypeOfX
	{
		static public bool Eval(this withType.VarI sub,withType.VarI sup) {
			return IsSupTypeOfX.Eval(sup,sub);
		}
	}
}
