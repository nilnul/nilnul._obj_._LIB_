using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.members
{
	/// <summary>
	/// try to demote to call
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface DemoteI<out T>
	{
		/// <summary>
		/// if it's a call, eval it.
		/// </summary>
		/// <returns></returns>
		ExprI<T> demote();

	}
}
