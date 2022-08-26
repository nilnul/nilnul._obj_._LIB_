using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr._stati
{
	/// <summary>
	/// try to demote to call
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface ReduceI<out T>
	{
		/// <summary>
		/// if it's a call, eval it.
		/// </summary>
		/// <returns></returns>
		StatiI<T> reduce();

	}
}
