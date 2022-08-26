using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr
{
	[Obsolete()]

	public interface ExprI_dynamic
		:ExprI_blank
		,
		_members.TypeI
		,
		_members.VarsI
		,
		_members.ReduceI
		,
		_members.SubstituteI
	{

	}
}
