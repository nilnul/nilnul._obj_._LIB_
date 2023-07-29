using nilnul.obj._expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete()]

	public interface ExprI_dynamic1
		:ExprI_blank1
		,
		_expr.TypeI1
		,
		_expr.VarsI1
		,
		_expr.ReduceI1
		,
		_expr.SubstituteI1
	{

	}
}
