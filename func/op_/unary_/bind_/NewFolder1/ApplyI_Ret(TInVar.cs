using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public partial interface ApplyI_Ret<out Ret>

	{

		Ret apply<Var>(
			
			expr.ExprI<Var> arg
		);


	}
}
