using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op.unary
{
	public partial class Closed<T>
		:nilnul.obj.var.expr.op.Unary<T,T>
		,
		
		nilnul.obj.var.expr.op.unary.ClosedI<T>
	{

		public Closed(
			nilnul.obj.op.Unary<T,T> op
		)
			:base(op)
		{

		}


		
	}
}
