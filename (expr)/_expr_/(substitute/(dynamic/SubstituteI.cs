using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr
{
	[Obsolete()]

	public partial interface SubstituteI1
	{
		ExprI_dynamic substitute( nilnul.obj._var.VarI_dynamicTyped var, ExprI_dynamic expr);

	}
}
