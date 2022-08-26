using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.type.rel
{
	static public class IsSupTypeOfX
	{
		static public bool Eval(Type sup, Type sub) {
			return sup.IsAssignableFrom(sub);

		}

		static public void Assert(Type sup, Type sub)
		{
			obj.AssertX.True(Eval(sup, sub));

		}
	}
}
