using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.func._stati;
using nilnul.obj.var;
using nilnul.obj.var.stati;
using nilnul.obj.var.stati.s.b;
using nilnul.obj.var.stati.set;
using nilnul.obj.var.stati.s;

namespace nilnul.obj.func.stati
{
	public class ExprAsFunc<TInExpr>
		:
		ExprAsFunc<TInExpr,obj.expr.StatiI<TInExpr>>
		
		

	{

		public ExprAsFunc(obj.expr.StatiI<TInExpr> expr):base(expr)
		{

		}
		
		

	}

	public class ExprAsFunc<TInExpr,TExpr>
		:

		//, ApplyI_varRet<object, Expr2<TInExpr>>
		//,ApplyI<Object,Nullary<TInExpr>>
		//_stati.VarsI
		//,

		_stati.VarsI_sDistinct<obj.var.stati.s.Empty>
		,

		obj.func._stati.ExprAsMemberI<TInExpr,TExpr>

		,

		_stati.ApplyI<expr.StatiI, ExprAsFunc<TInExpr,TExpr>>
		,
		
		func.StatiI<TInExpr>

		

		where TExpr:obj.expr.StatiI<TInExpr>

		

	{
		private TExpr _expr;

		public TExpr expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public 	Distinct<Empty>.Asserted vars
		{
			get
			{
				return new Distinct<Empty>.Asserted( new Empty());
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return string.Format("{0}", _expr);
		}

		public string ToString_nullary()
		{
			return string.Format("(){0}{1}", FuncX.GoesTo, _expr);
		}

		public ExprAsFunc(
			TExpr expr
		)
		{
			_expr = expr;
		}
		
		

		public  ExprAsFunc<TInExpr,TExpr> apply(expr.StatiI  arg)
		{
			return this;
			throw new NotImplementedException();
		}



		public StatiI<TInExpr> substitute<T>(Stati<T> var, expr.StatiI<T> expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
