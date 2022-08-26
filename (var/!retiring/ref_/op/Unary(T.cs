using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.ref_.op
{
	public partial class Unary<P,R>
	{
		private obj.op.UnaryI<P,R> _op;

		public obj.op.UnaryI<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public ExprI<R> eval(ExprI<P> arg) {

			return new Expr(this, arg);
 

		
		}

		public class Expr:ExprI<R>
		{
			private ExprI<P> _arg;

			public ExprI<P> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private Unary<P,R> _op;

			public Unary<P,R> op
			{
				get { return _op; }
				set { _op = value; }
			}

			public Expr(Unary<P,R> op, ExprI<P> arg)
			{
				this.arg = arg;
				this.op = op;

			}
			
			
			
		}
		
	}
}
