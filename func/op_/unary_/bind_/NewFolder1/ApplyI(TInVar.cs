using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public partial interface ApplyI<in Var>

	{

		void apply(
			
			expr.ExprI<Var> arg
		);


	}
}
