using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial interface UnaryI<P,R>
		:nilnul.obj.op.UnaryI< 
			nilnul.obj.var.ExprI<P>
			,
			nilnul.obj.var.ExprI<R>
		>
	{

	}
}
