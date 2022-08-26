using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.input.compo
{
	public partial class WithExpr<TInputs, TInExpr>
	{
		private TInputs _inputs;

		public TInputs inputs
		{
			get { return _inputs; }
			set { _inputs = value; }
		}

		private obj.expr.ExprI<TInExpr> _expr;

		public obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		
		
		public WithExpr()
		{
			

		}
	}
}
