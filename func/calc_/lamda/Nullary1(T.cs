using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	/// <summary>
	/// As if there is a bounded var that's different than any. Will return the expr when applied to any var.
	/// </summary>
	/// <typeparam name="TVar"></typeparam>
	/// <typeparam name="TExpr"></typeparam>
	public partial class Nullary1<TExpr>
		//:LambdaI<TExpr>
	{
	

		private ExprI2<TExpr> _expr;

		public ExprI2<TExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Nullary1(
			ExprI2<TExpr> expr
		)
		{
			this.expr = expr;

		}

		public Nullary1<TExpr> substitute() {

			return this;

			throw new NotImplementedException();
		}

		public Nullary1<TExpr> substitute(VarI var)
		{

			return this;

			throw new NotImplementedException();
		}

		public Nullary1<TExpr> apply(ExprI expr) {

			return this;
		
		} 

		
	}
}
