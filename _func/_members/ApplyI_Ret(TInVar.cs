using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._func._members
{

	public partial interface ApplyI_Ret<out TRet>

	{

		TRet apply<TInVar>(
			
			_expr.ExprI<TInVar> arg
		);


	}
}
