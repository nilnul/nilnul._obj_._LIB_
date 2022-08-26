using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public partial interface SubstituteInPlaceI
	{

		void substitute<TArg>(nilnul.obj.VarI3<TArg> var, nilnul.obj.expr.ExprI<TArg> expr);


	}
}
