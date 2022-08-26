using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{


	public class CallFroExpr<TInExpr>
		: FuncI<VarVoid, CallFroExpr<TInExpr>>
	{
		private nilnul.obj.expr.ExprI<TInExpr> _expr;

		public nilnul.obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}


	}

	public class CallFroExpr<TVar, TExpr>
		: CallFroExpr<TExpr>
		,
		FuncI<TVar, TExpr>
	{
		private nilnul.obj.VarI2<TVar> _var;

		public nilnul.obj.VarI2<TVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

	}

	public class CallFroExpr_voidVar<TExpr>
		: CallFroExpr<VarVoid, TExpr>
	{


	}



}
