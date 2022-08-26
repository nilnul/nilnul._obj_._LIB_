using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Abstract<TVar, TVarDomain,TVarRange, TExpr_Domain,TExpr_Range, TLambdaExpr>
	{
		static public Expr Eval(
			LambdaI1<TVarDomain, TVarRange> var
			,
			LambdaI1<TExpr_Domain, TExpr_Range> lambdaConstant	
		) {

			return new Expr(var, lambdaConstant);

			throw new NotImplementedException();
		}

		public class Expr:LambdaI1<LambdaI1<TVarDomain,TVarRange>,LambdaI1<TExpr_Domain,TExpr_Range>>
		{
			private LambdaI1<TVarDomain,TVarRange> _var;

			public LambdaI1<TVarDomain, TVarRange> var
			{
				get { return _var; }
				set { _var = value; }
			}

			private LambdaI1<TExpr_Domain, TExpr_Range> _expr;

			public LambdaI1<TExpr_Domain, TExpr_Range> expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			public Expr(LambdaI1<TVarDomain, TVarRange> var, LambdaI1<TExpr_Domain, TExpr_Range> expr)
			{
				this.var = var;
				this.expr = expr;

			}
			

		}
	}
}
