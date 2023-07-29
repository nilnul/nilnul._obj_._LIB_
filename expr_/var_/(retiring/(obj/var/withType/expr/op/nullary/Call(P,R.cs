using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op.nullary
{
		public partial class Call<P,R>
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

			public ExprI<R> substitute<V>(VarI<V> var, ExprI<V> expr)
			{
				return _expr.substitute(var, expr);

				throw new NotImplementedException();
			}

			public ExprI<R> demote()
			{
				return _expr.demote();

				throw new NotImplementedException();
			}
		}
	
}
