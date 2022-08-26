using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.obj.lambda.op
{
	public partial class AbstractExpr<TVar, TExpr>
		:LambdaI
	{
		public class Call
		{
			private nilnul.obj.VarI2<TVar> _var;

			public nilnul.obj.VarI2<TVar> var
			{
				get { return _var; }
				set {
					_var = value; 
				}
			}

			private lambda.Expr<TExpr> _expr;
			public lambda.Expr<TExpr> expr
			{
				get { return _expr; }
				set { _expr = value; }
			}
		}
	}
}
