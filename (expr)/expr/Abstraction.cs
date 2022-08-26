using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	public partial class Abstraction<TVar,TExpr>
	{
		private VarI<TVar> _var;

		public VarI<TVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private ExprI<TExpr> _expr;

		public ExprI<TExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Abstraction(
			VarI<TVar> var
			,ExprI<TExpr> expr
		)
		{
			this.var = var;
			this.expr = expr;

		}


		/// <summary>
		/// if this is the last var, change the expr to an op.call.
		/// </summary>
		/// <param name="newExpr"></param>
		/// <returns></returns>
		public ExprI<TExpr> substitute(ExprI<TVar> newExpr) {

			return expr.substitute(var, newExpr);
		
		}



	}
}
