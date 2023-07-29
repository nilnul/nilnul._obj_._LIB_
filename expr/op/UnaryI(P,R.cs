using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
{
	public partial interface UnaryI<P,R>
		:nilnul.obj.op.UnaryI< 
			ExprI<P>
			,
			ExprI<R>
		>
	{

	}
}
