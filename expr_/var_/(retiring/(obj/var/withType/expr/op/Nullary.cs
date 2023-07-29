using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.var.withType.expr.members;

namespace nilnul.obj.var.withType.expr.op
{
	public partial class Nullary
	{
		private ExprI _expr;

		public ExprI expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		
		public Nullary(ExprI expr )
		{
			this._expr= expr;

		}

		public ExprI eval()
		{
			return new Call_inExprDirectly(_expr);

			throw new NotImplementedException();
		}

		public partial class Call_inExprDirectly
			:
			ExprI
		{

			private ExprI _expr;

			public ExprI expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			public Type type
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public Call_inExprDirectly(
				ExprI expr
			)
				
			{
				this._expr = expr;

			}

			
			ExprI DemoteI.demote()
			{
				return _expr.demote();

				throw new NotImplementedException();
			}

			public ExprI substitute(withType.VarI var, ExprI expr)
			{
				return _expr.substitute(var, expr);

				throw new NotImplementedException();
			}
		}
	}
}
