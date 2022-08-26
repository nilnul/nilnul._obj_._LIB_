using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	/// <summary>
	/// an abstraction from an expression.
	/// </summary>
	/// <remarks>
	/// 
	/// Different from lambda in that lambda is the abstraction of var of func. lambda is the calculation of var of funcs, while func is the abstraction of expressions of concrete objects with funcs always concrete (not referenced by variable.).
	/// promote nilnul.obj.FuncI to nilnul.obj.func.FuncI for convenience and wrapping.
	/// 
	/// </remarks>
	public abstract partial class FuncA<TInParam, TRet>
		:FuncI<TInParam,TRet>
	{




		//public abstract void bind(expr.ExprI<TInParam> arg);

		public abstract TRet ret
		{
			get;
		}

		public abstract void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr);

		public abstract void reduce();

		public abstract TRet apply(expr.ExprI<TInParam> arg);

		public abstract HashSet<VarI1> boundVars
		{
			get;
		}

		public abstract FuncI<TInParam, TRet> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		;

		public abstract FuncI<TInParam, TRet> reduce2new();
	}
}
