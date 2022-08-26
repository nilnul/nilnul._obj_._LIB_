using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	/// <summary>
	/// an expression with all literals.
	/// </summary>
	 //[Obsolete("use nilnul_obj.op.ConstI")]
	public partial interface ConstI<out T> : ExprI3<T>, ExprI<T>, ConstI
	{

		T eval();
	}

	
}
