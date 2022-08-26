using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.members
{
	public partial interface Promote<out T>
	{
		ExprI<T> promote();

	}
}
