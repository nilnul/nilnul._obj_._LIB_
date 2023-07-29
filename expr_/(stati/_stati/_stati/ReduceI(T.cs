using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.stati._stati
{
	public  interface ReduceI<out T>
	{
		T reduce();

	}
}
