using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{


	public class Expr<TInExpr>
		: FuncI<Void, Expr<TInExpr>>

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

		public Expr(
			nilnul.obj.expr.ExprI<TInExpr> expr	
		)

		{
			_expr = expr;

		}


		public FuncI<Void, Expr<TInExpr>> substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
	//	public  Expr<TInExpr> substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			return new Expr<TInExpr>(_expr.substitute(var,expr));

			throw new NotImplementedException();
		}

		public Expr<TInExpr> rule
		{
			get {
				return this;
				throw new NotImplementedException(); }
		}

		public VarI3<Void> param
		{
			get {

				return VarVoid.Singleton;
				
				throw new NotImplementedException(); }
		}

		public void reduce()
		{
			_expr=_expr.demote();
			return;

			throw new NotImplementedException();
		}
	}




}
