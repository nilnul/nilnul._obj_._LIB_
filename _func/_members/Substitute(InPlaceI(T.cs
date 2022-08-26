using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._func._members
{

	public partial interface SubstituteInPlaceI<in TArg>
	{

		void substitute(nilnul.obj._var.VarI<TArg> var, nilnul.obj._expr.ExprI<TArg> expr);


	}
}
