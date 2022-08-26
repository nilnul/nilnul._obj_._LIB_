using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	[Obsolete()]
	public partial interface BindI<in Var>
	{

		void bind(
			
			expr.ExprI<Var> arg
		);


	}
}
