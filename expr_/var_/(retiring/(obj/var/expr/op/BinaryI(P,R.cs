using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial interface BinaryI<P,P1,R>
		:nilnul.obj.op.BinaryI< 
			nilnul.obj.var.ExprI<P>
			,
			nilnul.obj.var.ExprI<P1>
			,
			nilnul.obj.var.ExprI<R>
		>
	{



	}
}
