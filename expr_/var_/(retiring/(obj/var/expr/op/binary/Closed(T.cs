using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op.binary
{
	public partial class Closed<T>
		:nilnul.obj.var.expr.op.Binary<T,T,T>
		,
		
		nilnul.obj.var.expr.op.binary.ClosedI<T>
	{

		public Closed(
			nilnul.obj.op.Binary<T,T,T> op
		)
			:base(op)
		{

		}


		
	}
}
