using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op.binary
{
	public partial class Closed<T>
		:nilnul.obj.expr.op.Binary1<T,T,T>
		,
		
		nilnul.obj.expr.op.binary.ClosedI<T>
	{

		public Closed(
			nilnul.obj.op.BinaryI<T,T,T> op
		)
			:base(op)
		{

		}


		
	}
}
