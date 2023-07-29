using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial interface TernaryI<P,P1,P2,R>
		:nilnul.obj.op.TernaryI< 
			nilnul.obj.var.ExprI<P>
			,
			nilnul.obj.var.ExprI<P1>
			,
			nilnul.obj.var.ExprI<P2>
			,
			nilnul.obj.var.ExprI<R>
		>
	{



	}
}
