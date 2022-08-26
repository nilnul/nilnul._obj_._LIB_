using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.var.expr.call
{
	public partial class OnExpr<P,R>
	{
		private unary.var.ExprI<P,R>	_op;

		public unary.var.ExprI<P,R>	op
		{
			get { return _op; }
			set { op = value; }
		}


		

	}
}
