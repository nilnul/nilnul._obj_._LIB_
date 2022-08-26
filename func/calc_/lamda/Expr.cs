using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.obj.lambda
{
	public partial class Expr<T>
		:LambdaI<Expr<T>>
		,SubstituteI
	{

		private nilnul.obj.expr.ExprI<T> _expr;

		public nilnul.obj.expr.ExprI<T> expr
		{
			get { return _expr; }
			set {
				
				_expr = value; 
			}
		}

		public Expr( nilnul.obj.expr.ExprI<T> expr)
		{
			this._expr = expr;

		}


		public void substitute<V>(VarI2<V> var, expr.ExprI<V> expr)
		{
			_expr= _expr.substitute(var, expr);
			return;

			throw new NotImplementedException();
		}
	}
}
