using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.ref_.op.expr
{
	public partial class AbstractI<P,R>
	{
		private Var2<P> _var;

		public Var2<P> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private ExprI<R> _expr;

		public ExprI<R> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}


		
		


	}
}
