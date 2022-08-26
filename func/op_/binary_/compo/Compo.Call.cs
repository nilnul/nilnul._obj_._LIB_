using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Compo
	{
		public class Call<TInVar,TRet, TInExpr,  TRet1,TInExpr1>
			:
			BoundVarsI
			,
			FuncI<TInExpr1>
			,
			FuncI__Var_Expr<TInVar,TInExpr1>
			,
			VarAsPropI<TInVar>

			where TRet:FuncI<TInExpr>
			where TRet1:FuncI<TInExpr1>
		{
			private FuncI<TInVar,TRet, TInExpr> _func;

			public FuncI<TInVar, TRet, TInExpr> func
			{
				get { return _func; }
				set { _func = value; }
			}

			private FuncI<TInExpr,TRet1,TInExpr1> _func1;
			public FuncI<TInExpr,TRet1,TInExpr1> func1
			{
				get { return _func1; }
				set { _func1 = value; }
			}

			public Call(FuncI<TInVar,TRet,TInExpr> func, FuncI<TInExpr,TRet1,TInExpr1> func1)
			{
				_func = func;
				_func1 = func1;
			}

			public HashSet<VarI1> boundVars
			{
				get {
					var funcVar = (func as VarAsPropI<TInVar>).var;
					var funcRet = func.ret;

					var funcExpr = (func as ExprAsMemberI<TInExpr>).expr;
					var func1applied = func1.apply(funcExpr);

					var func1Var = (func1 as VarAsPropI<TInExpr>).var;

					var newBoundVars=funcRet.boundVars;
					newBoundVars.UnionWith(func1.ret.boundVars);

					return newBoundVars;
					
					throw new NotImplementedException(); 
				
				}
			}

			public expr.ExprI<TInExpr1> expr
			{
				get {
					return func1.apply(func.expr).expr;

					throw new NotImplementedException(); 
				}
			}

			public TRet apply(
				obj.expr.ExprI<TInVar> expr
			){
				throw new NotImplementedException();	
			}

			public void reduce() { 


				
			}

			public FuncI<TInVar, TRet_Evaled, TInExpr1> eval<TRet_Evaled>() {
				//return op.Param.Eval(var, 
				throw new NotImplementedException();
			}

			public VarI3<TInVar> var {

				get {
					return (func as VarAsPropI<TInVar>).var;
				}
			
			}
			public void bind(expr.ExprI<TInVar> arg)
			{
				expr.substitute((func as VarAsPropI<TInVar>).var, arg);
				return;

				throw new NotImplementedException();
			}
		}
	}
}
