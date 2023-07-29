using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.set.ordered
{
	static public class ExtensionMethods
	{
		static public Ordered Append(this Ordered ordered, _var.VarI_dynamicTyped var) {
			var r = new Ordered(ordered);
			r.append(var);
			return r;

			
		}
		static public Ordered Prepend(this Ordered ordered, _var.VarI_dynamicTyped var) {
			var r = new Ordered(ordered);
			r.prepend(var);
			return r;

			
		}
		static public Ordered Rename(this Ordered ordered, _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew) {
			return Ordered.Rename(ordered, var, varNew);
		}
		

	}
}
