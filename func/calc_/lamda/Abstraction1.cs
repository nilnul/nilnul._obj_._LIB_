using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda.op.call
{
	public partial class Abstract1<TVar,TExpr>

		:LambdaI

		where TExpr:LambdaI
		//nilnul.obj.op.UnaryI<ExprI2<TVar>,ExprI2<TExpr>>
		//,
	{
		private  nilnul.obj.ValI<TVar> _var;

		public nilnul.obj.ValI<TVar>   var
		{
			get { return _var; }
			set { _var = value; }
		}

		private LambdaI<TExpr> _expr;

		public LambdaI<TExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Abstract1(
			VarI2<TVar> var
			,LambdaI<TExpr> expr
		)
		{
			this.var = var;
			this.expr = expr;

		}



		public Abstract1<TVar,TExpr> substitute(VarI2<TVar> var, LambdaI<TVar> expr)
		{
			return new Abstract1<TVar,TExpr>( var, expr.substitute(var,expr));
			throw new NotImplementedException();
		}

		public LambdaI<TExpr> apply(ExprI2<TVar> expr)
		{
			throw new NotImplementedException();
		}
	}
}
