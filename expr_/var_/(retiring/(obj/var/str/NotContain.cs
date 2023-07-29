using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.str
{
	static public class NotContainX
	{
		

		static public bool NotContain(this IEnumerable<VarI1> str, VarI1 x)
		{
			return !str.Contain(x);
		}


	}
}
