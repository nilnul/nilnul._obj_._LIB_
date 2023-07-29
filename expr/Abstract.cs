using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	public partial class Abstract<TVar,TExpr>
		:nilnul.obj.op.UnaryI<ExprI2<TVar>,ExprI2<TExpr>>
	{
		private VarI2<TVar> _var;

		public VarI2<TVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private ExprI2<TExpr> _expr;

		public ExprI2<TExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Abstract(
			VarI2<TVar> var
			,ExprI2<TExpr> expr
		)
		{
			this.var = var;
			this.expr = expr;

		}

		 public ExprI2<TExpr> eval(ExprI2<TVar> a)
		 {

			 return expr.substitute(var,a);

			 throw new NotImplementedException();
		 }
	}
}
