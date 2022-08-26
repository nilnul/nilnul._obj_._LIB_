using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._func._members
{

	public partial interface ApplyI<in TInVar, out TRet>

	{

		TRet apply(
			
			_expr.ExprI<TInVar> arg
		);


	}
}
