using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj
{
	/// <summary>
	/// an expression with all literals.
	/// </summary>
	 //[Obsolete("use nilnul_obj.op.ConstI")]

		[Obsolete()]
	public partial interface ConstI<out T> : ExprI<T>,  ConstI
	{

		T eval();
	}

	
}
