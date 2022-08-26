using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface LiteralI<out T>
		:obj.var.ExprI<T>
		,LiteralI
	{
	}
}
