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
	public partial class Binary<TInVar,TInVar1,TInExpr>
		:FuncA<TInVar,Unary<TInVar1,TInExpr>>
		,Reduce2newI<Binary<TInVar, TInVar1,TInExpr>>
		,
		Substitute2NewI<Binary<TInVar,TInVar1,TInExpr>>
		,
		ExprAsMemberI<TInExpr>
	{
		private obj.VarI3<TInVar> _var;

		public obj.VarI3<TInVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private obj.VarI3<TInVar1> _var1;

		public obj.VarI3<TInVar1> var1
		{
			get { return _var1; }
			set { _var1 = value; }
		}

		private obj.expr.ExprI<TInExpr> _expr;

		public obj.expr.ExprI<TInExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		
		public Binary(obj.VarI3<TInVar> var, obj.VarI3<TInVar1> var1, obj.expr.ExprI<TInExpr> expr )
		{
			_var = var;
			_var1 = var1;
			_expr = expr;
		}

		public override Unary<TInVar1,TInExpr> ret
		{
			get {
				return new Unary<TInVar1,TInExpr>(_var1, _expr);
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

		public override Unary<TInVar1,TInExpr> apply(expr.ExprI<TInVar> arg)
		{
			return new Unary<TInVar1,TInExpr>(_var1, _expr.substitute(_var, arg));
			throw new NotImplementedException();
		}

		public override Binary<TInVar, TInVar1, TInExpr> reduce2new()
		{
			return new Binary<TInVar, TInVar1, TInExpr>(_var, _var1, _expr.demote());
			throw new NotImplementedException();
		}



		public override Binary<TInVar, TInVar1, TInExpr> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{
			return new Binary<TInVar, TInVar1, TInExpr>(_var, _var1, _expr.substitute(var, expr));
			throw new NotImplementedException();
		}

		public override HashSet<VarI1> boundVars
		{
			get {
				return new HashSet<VarI1>( new VarI1[]{_var,_var1});
				throw new NotImplementedException(); }
		}
	}
}
