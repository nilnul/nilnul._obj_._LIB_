using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	public partial interface VarI<out T>
		:ExprI<T>
		,VarI
	{

	}
}
