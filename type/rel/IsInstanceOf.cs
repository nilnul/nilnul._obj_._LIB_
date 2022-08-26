using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.type.rel
{
	static public class IsInstanceOf
	{
		static public bool Eval(object instance	, Type type) {
			return type.IsInstanceOfType(instance);
		}


		//static public void Assert(object instance, Type type) {
		//	nilnul.obj.AssertX.True(Eval(instance, type));
		//}

		static public void Assert(object instance, Type type) {
			nilnul.Assert1.True(Eval(instance,type));
		}

	
	}
}
