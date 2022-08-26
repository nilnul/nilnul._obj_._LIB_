using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	public partial interface SubstituteI1<out T>
	{
		ExprI<T> substitute<V>( nilnul.obj.VarI2<V> var,ExprI<V> expr);

	}
}
