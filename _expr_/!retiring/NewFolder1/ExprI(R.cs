using nilnul.obj._expr._members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr
{

	[Obsolete()]

	public interface ExprI<out R>
		:ExprI_dynamic
		,
		ReduceI<R>
		,
		SubstituteI<R>
	{

	}
}
