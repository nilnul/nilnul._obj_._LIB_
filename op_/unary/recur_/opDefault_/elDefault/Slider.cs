using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur_.opDefault_.elDefault
{
	public class Slider<T, TOp>
		:
		recur.slider_.RecurDefault<
			T, TOp, IniDefault<T,TOp>
		>
		where TOp : nilnul.obj.op_.UnaryI<T>,new()

		where T : new()

	{
		

	}
	

}
