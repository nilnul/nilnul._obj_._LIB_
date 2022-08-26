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
	public partial interface FuncI_memberTyped
	{

		VarI3<T> getVar<T>();
		ExprI3<T> getExpr<T>();

		void substitue<T>(VarI3<T> var, expr.ExprI<T> expr);

		void apply<T>( expr.ExprI<T> expr);






	}
}
