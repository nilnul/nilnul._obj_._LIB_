using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	public partial interface ExprI<out T>:
		ExprI3<T>
		,
		SubstituteI<T>
		,
		DemoteI<T>
		,ExprI
	{
		//ExprI<T> substitute<V>( VarI<V> var,ExprI<V> expr);
		/// <summary>
		/// if no var, try to execute.
		/// </summary>
		/// <returns></returns>

	}
}
