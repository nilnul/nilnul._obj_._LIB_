using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr._members
{
	[Obsolete()]

	public partial interface SubstituteI
	{
		ExprI_dynamic substitute( nilnul.obj._var.VarI_dynamicTyped var, ExprI_dynamic expr);

	}
}
