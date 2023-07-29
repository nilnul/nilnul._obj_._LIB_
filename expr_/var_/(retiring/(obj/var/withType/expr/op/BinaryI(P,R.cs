using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.op
{
	public partial interface BinaryI<P,P1,R>
		:nilnul.obj.op.BinaryI< 
			ExprI<P>
			,
			ExprI<P1>
			,
			ExprI<R>
		>
	{



	}
}
