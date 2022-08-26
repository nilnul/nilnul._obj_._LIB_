using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{


	public class Expr1<TInExpr>
		:ParamVoidA
 		,
		FuncI1<Void, Expr1<TInExpr>>
		,
		ApplyI<Expr1<TInExpr>>

	{
		private nilnul.obj.expr.ExprI<TInExpr> _expr;

		public nilnul.obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public override string ToString()
		{
			return string.Format("{0}", _expr);
		}

		public  string ToString_nullary()
		{
			return string.Format("(){0}{1}",FuncX.GoesTo, _expr);
		}

		public Expr1(
			nilnul.obj.expr.ExprI<TInExpr> expr	
		)

		{
			_expr = expr;

		}


	

		public Expr1<TInExpr> ret
		{
			get {
				return this;
				
				throw new NotImplementedException(); 
			}
		}


		public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			_expr.substitute(var, expr);
			return ;

			throw new NotImplementedException();
		}

		public void reduce()
		{
			_expr=_expr.demote();
			return;
			throw new NotImplementedException();
		}



		public new VarI3<Void> param
		{
			get {
				return base.param;
				throw new NotImplementedException(); 
			}
		}

		public Expr1<TInExpr> apply<Arg>(expr.ExprI<Arg> arg)
		{
			return this;

			throw new NotImplementedException();
		}
	}




}
