using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
{
	public partial class Nullary1<R>
		:NullaryI<R>
	{
		private ExprI<R> _expr;

		public ExprI<R> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		
		public Nullary1(ExprI<R> expr )
		{
			this._expr= expr;

		}

		public ExprI<R> eval()
		{
			return new Call(_expr);

			throw new NotImplementedException();
		}

		public partial class Call
			:
			ExprI<R>
		{

			private ExprI<R> _expr;

			public ExprI<R> expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			public Call(
				ExprI<R> expr
			)
				
			{
				this._expr = expr;

			}

			public ExprI<R> substitute<V>(VarI3<V> var, ExprI<V> expr)
			{
				return _expr.substitute(var, expr);

				throw new NotImplementedException();
			}

			public ExprI<R> demote()
			{
				throw new NotImplementedException();
			}
		}
	}
}
