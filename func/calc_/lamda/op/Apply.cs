using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda.op
{
	public partial class Apply
	{
		public class Call<TVar,TExpr>
			:LambdaI<TExpr>
		{
			private LambdaI<TVar,TExpr>	_expr;

			public LambdaI<TVar,TExpr>	expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			private obj.expr.ExprI<TVar> _arg;

			public obj.expr.ExprI<TVar> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}
			




			
			
		}
	}
}
