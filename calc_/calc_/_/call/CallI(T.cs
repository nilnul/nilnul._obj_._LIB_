using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call
{
	[Obsolete()]
	public partial interface CallI<out T>:
		EvalI<T>
		,
		nilnul.obj.CallI<T>
		,
		CallI
	{
	}
}
