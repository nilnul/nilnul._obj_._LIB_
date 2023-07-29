using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.ref_.op
{
	public partial class Nullary<R>
	{
		private obj.RefI<R> _val;

		public obj.RefI<R> val
		{
			get { return _val; }
			set { _val = value; }
		}

		public ExprI<R> eval() {

			return new Expr(this);
		
		}

		public class Expr:ExprI<R>
		{
			



			private Nullary<R> _op;

			public Nullary<R> op
			{
				get { return _op; }
				set { _op = value; }
			}

			public Expr(Nullary<R> op)
			{
				this.op = op;

			}
			
			
			
		}
		
	}
}
