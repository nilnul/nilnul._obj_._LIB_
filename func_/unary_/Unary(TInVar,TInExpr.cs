using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	/// <summary>
	/// abstraction from expr
	/// </summary>
	/// <typeparam name="TInVar"></typeparam>
	/// <typeparam name="TInExpr"></typeparam>
	public partial class Unary<TInVar,TInExpr>
		:FuncA<TInVar,Nullary<TInExpr>>

		,
		Substitute2NewI<Unary<TInVar,TInExpr>>

		,
		Reduce2newI<Nullary<TInExpr>>
		,
		ExprAsMemberI<TInExpr>

	{
		private obj.VarI3<TInVar> _var;

		public obj.VarI3<TInVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private obj.expr.ExprI<TInExpr> _expr;

		public obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		
		
		public Unary(obj.VarI3<TInVar> var, obj.expr.ExprI<TInExpr> expr )
		{
			_var = var;
			_expr = expr;

		}

		public override string ToString()
		{
			return string.Format("{0}{1}{2}",_var,FuncX.GoesTo,expr);
		}

		public override Nullary<TInExpr> ret
		{
			get {
				return new Nullary<TInExpr>(_expr);
				
				throw new NotImplementedException(); 
			}
		}

		public override void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			_expr.substitute(var, expr);
			return;
			throw new NotImplementedException();
		}

		public override void reduce()
		{
			_expr=_expr.demote();
			return;
			throw new NotImplementedException();
		}

		public override Nullary<TInExpr> apply(expr.ExprI<TInVar> arg)
		{
			return new Nullary<TInExpr>(_expr.substitute(_var, arg));
			throw new NotImplementedException();
		}

		public Nullary<TInExpr> apply(TInVar arg) {
			return apply(new expr.Call<TInVar>(arg));
		}

		public override FuncI<TInVar, Nullary<TInExpr>> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			return new Unary<TInVar, TInExpr>(this.var, _expr.substitute(var, expr));
			throw new NotImplementedException();
		}

		public new Nullary<TInExpr> reduce2new()
		{
			return new Nullary<TInExpr>(_expr.demote());

			throw new NotImplementedException();
		}

		public override HashSet<VarI1> boundVars
		{
			get {
				return new HashSet<VarI1>(new []{_var} );
				throw new NotImplementedException(); 
			}
		}

		//public class Composite<TInVar,TInExpr,TInExpr1>
		//{
		//	private Unary<TInVar,TInExpr> _func;

		//	public Unary<TInVar,TInExpr> func
		//	{
		//		get { return _func; }
		//		set { _func = value; }
		//	}

		//	private Unary<TInExpr,TInExpr1> _func1;

		//	public Unary<TInExpr,TInExpr1> func1
		//	{
		//		get { return _func1; }
		//		set { _func1 = value; }
		//	}

		//	public Composite(
		//		Unary<TInVar,TInExpr> func
		//		,
		//		Unary<TInExpr,TInExpr1> func1
		//	)
		//	{
		//		if (func.var==func1.var)
		//		{
		//			var newVar=new obj.Var3<TInExpr>();
		//			func1 = new Unary<TInExpr, TInExpr1>(newVar,func1.expr.substitute(func1.var, new expr.Var<TInExpr>( newVar)));
				
		//		}

		//		_func = func;
		//		_func1 = func1;
		//	}

		//	public Unary<TInVar, TInExpr1> eval() {
		//		return new Unary<TInVar, TInExpr1>(
		//			_func._var
		//			,
		//			_func1.apply(_func._expr).expr
		//		);

		//		throw new NotImplementedException();
		//	}

		//	public override string ToString()
		//	{
		//		return string.Format("{0}{1}{2}",func,obj.func.op.CompoX.U2218, func1);
		//	}
			
			
		//}



		

		Unary<TInVar, TInExpr> Substitute2NewI<Unary<TInVar, TInExpr>>.substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{

			return new Unary<TInVar, TInExpr>(this.var, _expr.substitute(var, expr));

			throw new NotImplementedException();
		}
	}
}
