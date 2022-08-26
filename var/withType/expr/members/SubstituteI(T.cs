using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.members
{
	public partial interface SubstituteI<out T>
	{
		ExprI<T> substitute<V>( obj.VarI3<V> var,ExprI<V> expr);

	}
}
