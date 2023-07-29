using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr._stati
{
	public partial interface SubstituteI<out T>
	{
		StatiI<T> substitute<V>( nilnul.obj.var.Stati<V> var, expr.StatiI<V> expr);

	}
}
