using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr._members
{
	/// <summary>
	/// try to demote to call
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Obsolete()]

	public partial interface ReduceI<out T>
	{
		/// <summary>
		/// if it's a call, eval it.
		/// </summary>
		/// <returns></returns>
		ExprI<T> reduce_staticTyped();

	}
}
