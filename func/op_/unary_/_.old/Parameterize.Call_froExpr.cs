using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Param
	{
		public class Call_froExpr<TParam, TInExpr>
			:
			FuncI1<TParam, Expr<TInExpr>>
			,
			ParamI<TParam>

		{

			private nilnul.obj.expr.ExprI<TInExpr> _expr;

			public nilnul.obj.expr.ExprI<TInExpr> expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			private nilnul.obj.VarI3<TParam> _param;

			public nilnul.obj.VarI3<TParam> param
			{
				get { return _param; }
				set { _param = value; }
			}

			public Call_froExpr(nilnul.obj.VarI3<TParam> var, obj.expr.ExprI<TInExpr> expr)
			{
				_param = var;
				_expr = expr;


			}



			public Expr<TInExpr> ret
			{
				get {
					return new Expr<TInExpr>(_expr);
					
					throw new NotImplementedException(); 
				
				}
			}

			public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				_expr=_expr.substitute(var, expr);

				return;
				throw new NotImplementedException();
			}

			public void reduce()
			{
				_expr=_expr.demote();
				return;

				throw new NotImplementedException();
			}
		}
	}
}
