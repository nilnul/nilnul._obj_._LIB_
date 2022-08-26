using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op.unary
{
	public partial class Closed<T>
		:nilnul.obj.expr.op.Unary<T,T>
		,
		
		nilnul.obj.expr.op.unary.ClosedI<T>
	{

		public Closed(
			nilnul.obj.op.Unary<T,T> op
		)
			:base(op)
		{

		}

		


		
	}
}
