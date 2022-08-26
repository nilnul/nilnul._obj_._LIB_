using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public partial interface ExprI<P,R>
		:ExprI<R>
	{
		obj.op.unary.VarI<P, R> op { get; set; }
		obj.op.ExprI<R> arg { get; set; }
	}
}
