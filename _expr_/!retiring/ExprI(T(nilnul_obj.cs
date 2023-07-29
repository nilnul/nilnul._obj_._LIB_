using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj
{
	/// <summary>
	/// Literal(T), or  or OpCallI(T)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	//[Obsolete("See op call in nilnul_obj.op")]
	public partial interface ExprI<out T>:ExprI
	{

	}
}
