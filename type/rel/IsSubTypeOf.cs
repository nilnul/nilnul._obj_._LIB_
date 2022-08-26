using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.type.rel
{
	static public class IsSubTypeOfX
	{
		static public bool Eval(Type sub, Type sup) {
			return IsSupTypeOfX.Eval(sup, sub);
		}

		static public void Assert(Type sub, Type sup) {
			obj.AssertX.True(Eval(sub, sup));

		}
	}
}
