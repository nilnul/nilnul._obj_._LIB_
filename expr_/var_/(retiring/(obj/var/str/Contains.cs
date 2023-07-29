using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.str
{
	static public class _ContainX
	{
		

		static public bool Contain(this IEnumerable<VarI1> str, VarI1 x) {
			return str.Contains(x, var.Eq1.Instance);
		}


	}
}
