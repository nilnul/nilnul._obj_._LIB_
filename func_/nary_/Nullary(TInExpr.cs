using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public class Nullary<TInExpr>
		:
		ApplyA<object,Nullary<TInExpr>>,

		FuncI<object, Nullary<TInExpr>>

		//, ApplyI_varRet<object, Expr2<TInExpr>>
		//,ApplyI<Object,Nullary<TInExpr>>
		,
		
		Substitute2NewI<Nullary<TInExpr>>
		,Reduce2newI<Nullary<TInExpr>>
		,
		BoundVarsI
		,
		obj.func.ExprAsMemberI<TInExpr>
		,
		RetReplaceI<object>

		

	{
		private nilnul.obj.expr.ExprI<TInExpr> _expr;

		public nilnul.obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}


		public Nullary<TInNewExpr> exprReplace<TInNewExpr>( obj.expr.ExprI<TInNewExpr> expr) {

			return new Nullary<TInNewExpr>(expr);
		
		}

		public override string ToString()
		{
			return string.Format("{0}", _expr);
		}

		public string ToString_nullary()
		{
			return string.Format("(){0}{1}", FuncX.GoesTo, _expr);
		}

		public Nullary(
			nilnul.obj.expr.ExprI<TInExpr> expr
		)
		{
			_expr = expr;
		}
		public Nullary<TInExpr> ret
		{
			get
			{
				return this;
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
			_expr = _expr.demote();
			return;
			throw new NotImplementedException();
		}

		public Nullary<TInExpr> reduce2new()
		{
			return new Nullary<TInExpr>( _expr.demote());
			
			throw new NotImplementedException();
		}


		//public Expr2<TInExpr> apply<Arg>(expr.ExprI<Arg> arg)
		//{
		//	return this;

		//	throw new NotImplementedException();
		//}

		//public Expr2<TInExpr> apply(expr.ExprI<Void> arg)
		//{
		//	return this;
		//	throw new NotImplementedException();
		//}
	//	public Expr2<TInExpr> apply(expr.ExprI<object> arg)

		public void bind(expr.ExprI<object> arg)
		{
			return ;
			throw new NotImplementedException();
		}
		

		public override Nullary<TInExpr> apply(expr.ExprI<object> arg)
		{
			return this;
			throw new NotImplementedException();
		}

		public Nullary<TInExpr> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			return new Nullary<TInExpr>(_expr.substitute(var,expr) );
			throw new NotImplementedException();
		}

		public HashSet<VarI1> boundVars
		{
			get {
				return new HashSet<VarI1>();
				throw new NotImplementedException(); 
			}
		}

		public TRet retReplace<TRet>(TRet func)
			where TRet:FuncI
			
		{
			return func;

			throw new NotImplementedException();
		}
		public FuncI<TInVar,TRet> retReplace<TInVar,TRet>(FuncI<TInVar, TRet> func)
			
		{
			return retReplace<FuncI<TInVar,TRet>>( func);

			throw new NotImplementedException();
		}


		public TRet_arg compo< TRet_arg>( FuncI<TInExpr,TRet_arg> func ) {
			return func.apply(expr);

			throw new NotImplementedException();
		}

	

		FuncI<object, TFuncAsRet> RetReplaceI<object>.retReplace<TFuncAsRet>(TFuncAsRet funcAsRet)
		{
			throw new NotImplementedException();
		}

		//public TArg_Ret exprReplace<TArg_Ret,TArg_Expr>(FuncI<TInExpr, TArg_Ret,TArg_Expr> funcAsRet)
			

		//{
		//	return funcAsRet.apply(expr);

			
		//	throw new NotImplementedException();
		//}



		FuncI<object, Nullary<TInExpr>> Substitute2NewI<FuncI<object, Nullary<TInExpr>>>.substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{

			return substitute2new<TArg>(var, expr);

			throw new NotImplementedException();
		}

		FuncI<object, Nullary<TInExpr>> Reduce2newI<FuncI<object, Nullary<TInExpr>>>.reduce2new()
		{
			return reduce2new();
			throw new NotImplementedException();
		}
	}
}
