using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.function;

namespace nilnul.obj.op
{
	/// <summary>
	/// an expression that returns a function, a reference to a function (var)
	/// </summary>
	/// <typeparam name="T">
	/// 
	/// </typeparam>
	/// 
	public partial interface ExprI2<out T>:ExprI
	{
		/// <summary>
		/// eval the expr and get the result, which is of type T.
		/// </summary>
		/// <returns></returns>
		T eval();

	


	}
}
