using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr._members
{
	[Obsolete()]

	public partial interface SubstituteI<out T>
	{
		ExprI<T> substitute<V>( nilnul.obj._var.VarI<V> var,ExprI<V> expr);

	}
}
