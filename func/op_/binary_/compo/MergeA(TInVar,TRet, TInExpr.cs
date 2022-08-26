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
	public abstract partial class MergeA< TInVar, TRet,TInExpr>

		:FuncI<TInVar,TRet,TInExpr>
	
		where TRet:FuncI< TInExpr>, MergeI
	{


		public FuncI__Var_Expr<TInVar,TInExpr1> merge<TInVar1, TRet1, TInExpr1, TFunc>(
			TFunc func
			
		)
			where TFunc : FuncI<TInVar1, TRet1, TInExpr1>
		{
					var r=op.Param.Eval((this as VarAsPropI<TInVar>).var, this.ret
		}



		public HashSet<VarI1> boundVars
		{
			get { throw new NotImplementedException(); }
		}

		public expr.ExprI<TInExpr> expr
		{
			get { throw new NotImplementedException(); }
		}

		public void bind(expr.ExprI<TInVar> arg)
		{
			throw new NotImplementedException();
		}

		public TRet ret
		{
			get { throw new NotImplementedException(); }
		}

		public TRet apply(expr.ExprI<TInVar> arg)
		{
			throw new NotImplementedException();
		}
	}
}
