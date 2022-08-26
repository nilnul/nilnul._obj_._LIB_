using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.ref_.op
{
	public partial class Binary<P,P1,R>
	{
		private obj.op.UnaryI<P,R> _op;

		public obj.op.UnaryI<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public ExprI<R> eval(ExprI<P> arg,ExprI<P1> arg1) {

			return new Expr(this, arg,arg1);
 	
		}

		public class Expr:ExprI<R>
		{
			private ExprI<P> _arg;

			public ExprI<P> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}
			private ExprI<P1> _arg1;

			public ExprI<P1> arg1
			{
				get { return _arg1; }
				set { _arg1 = value; }
			}
			

			private Binary<P,P1,R> _op;

			public Binary<P,P1,R> op
			{
				get { return _op; }
				set { _op = value; }
			}

			public Expr(Binary<P,P1,R> op, ExprI<P> arg,ExprI<P1> arg1)
			{
				this.arg = arg;
				this.arg1 = arg1;
				this.op = op;

			}
			
			
			
		}
		
	}
}
