using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr
{
	public partial interface VarI<out T>
		:ExprI<T>
		,VarI
	{

	}
}
