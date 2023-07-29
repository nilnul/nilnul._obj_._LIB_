using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType.rel
{
	static public partial class IsSupTypeOfX
	{
		static public bool Eval(this withType.VarI sup,withType.VarI sub) {
			return sup.type.IsAssignableFrom(sub.type);
		}
	}
}
