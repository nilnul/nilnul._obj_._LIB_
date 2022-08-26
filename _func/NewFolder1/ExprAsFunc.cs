using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._expr;
using nilnul.obj._func._members;
using nilnul.obj.var.set;

namespace nilnul.obj._func
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// there is an invisible var, which of the Top type. So when applied, the replaced var is new to any other replaced-in var.
	/// </remarks>
	public class ExprAsFunc
		//:
		//ApplyA<object,ExprAsFunc<TInExpr>>,

		//FuncI<object, ExprAsFunc<TInExpr>>

		////, ApplyI_varRet<object, Expr2<TInExpr>>
		////,ApplyI<Object,Nullary<TInExpr>>
		//,

		//Substitute2NewI<ExprAsFunc<TInExpr>>
		//,Reduce2newI<ExprAsFunc<TInExpr>>
		//,
		//BoundVarsI
		//,
		//obj.func.ExprAsMemberI<TInExpr>
		//,
		//RetReplaceI<object>
		:FuncI_dynamic

		

	{
		private nilnul.obj._expr.ExprI_dynamic _expr;

		public nilnul.obj._expr.ExprI_dynamic expr
		{
			get { return _expr; }
			set { _expr = value; }
		}


	

		public override string ToString()
		{
			return ToString_nullary();
		}

		public string ToString_nullary()
		{
			return string.Format("(){0}{1}", FuncX.GoesTo, _expr);
		}
		public string ToString_vary()
		{
			return $"{_expr}{FuncX.VariedBy}{"()"}";	// string.Format("(){0}{1}", FuncX.GoesTo, _expr);
		}

		public ExprAsFunc(
			nilnul.obj._expr.ExprI_dynamic expr
		)
		{
			_expr = expr;
		}
		public ExprAsFunc ret
		{
			get
			{
				return this;
				throw new NotImplementedException();
			}
		}
		public void substitute<TArg>(_var.VarI<TArg> var, _expr.ExprI<TArg> expr)
		{
			_expr=_expr.substitute(var, expr);
			return;

			throw new NotImplementedException();
		}

		public void reduce()
		{
			_expr = _expr.reduce();
			return;
			throw new NotImplementedException();
		}

		public ExprAsFunc reduce2new()
		{
			return new ExprAsFunc( _expr.reduce());
			
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
		

		public  ExprAsFunc apply(_expr.ExprI<object> arg)
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprAsFunc substituteToNew(_var.VarI_dynamicTyped  var, _expr.ExprI_dynamic expr)
		{

			return new ExprAsFunc(_expr.substitute(var,expr) );
			throw new NotImplementedException();
		}

		public HashSet<VarI1> boundVars
		{
			get {
				return new HashSet<VarI1>();
				throw new NotImplementedException(); 
			}
		}

	

	
		public Ordered vars
		{
			get
			{
				return new Ordered();
				throw new NotImplementedException();
			}
		}

		public TRet retReplace<TRet>(TRet func)
			where TRet:FuncI_blank
			
		{
			return func;

			throw new NotImplementedException();
		}
	

	
	

		

		//public TArg_Ret exprReplace<TArg_Ret,TArg_Expr>(FuncI<TInExpr, TArg_Ret,TArg_Expr> funcAsRet)
			

		//{
		//	return funcAsRet.apply(expr);

			
		//	throw new NotImplementedException();
		//}



	

		
	}
}
