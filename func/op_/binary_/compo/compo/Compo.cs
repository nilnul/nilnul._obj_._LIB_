using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Compo
	{
		static public Nullary<T> Eval<T>(Nullary<T> nullary, FuncI func)
		{

			return nullary;
		}

		static public TRet Eval<TInVar, TRet>(FuncI<TInVar, TRet> func, func.Nullary<TInVar> nullary)
		{
			return func.apply(nullary.expr);
		}

		public Unary<TInVar, TInExpr1> Eval<TInVar, TInExpr, TInExpr1>(
			Unary<TInVar, TInExpr> func
			,
			Unary<TInExpr, TInExpr1> func1
		)
		{
			return new Unary<TInVar, TInExpr1>(
				func.var
				,
				func1.apply(func.expr).expr
			);

			throw new NotImplementedException();
		}


		public Binary<TInVar_unary, TInVar1, TInExpr> Eval<TInVar, TInVar1, TInExpr, TInVar_unary>(

				Unary<TInVar_unary, TInVar> func
			,

			Binary<TInVar, TInVar1, TInExpr> func2


			)
		{
			return new Binary<TInVar_unary, TInVar1, TInExpr>(
				func.var
				,
				func2.var1
				,
				func2.apply(func.expr).expr
			);

			throw new NotImplementedException();
		}


		public Binary<TInVar, TInVar1, TInExpr_unary> Eval<TInVar, TInVar1, TInExpr, TInExpr_unary>(
			Binary<TInVar, TInVar1, TInExpr> func,

			Unary<TInExpr, TInExpr_unary> func1
		)
		{
			return new Binary<TInVar, TInVar1, TInExpr_unary>(
				func.var
				,
				func.var1
				,
				func1.apply(func.expr).expr
			);

			throw new NotImplementedException();
		}

		public Param.Call<TInVar , Binary<TInVar1, TInVar_2_1,TInExpr_1>> Eval<TInVar, TInVar1, TInExpr,TInVar_2_1, TInExpr_1>(
			Binary<TInVar, TInVar1, TInExpr> func,

			Binary<TInExpr, TInVar_2_1, TInExpr_1> func1
		)
		{
			return Param.Eval(
				func.var, 
				new Binary<TInVar1, TInVar_2_1, TInExpr_1>(
					func.var1
					,
					func1.var1
					,
					func1.apply(func.expr).expr
				)
			);

			throw new NotImplementedException();
		}

		public Param.Call<TInVar,TRet_Valed > Eval<TInVar, TRet, TInExpr,TRet1,TRet_Valed>(
			Param.Call<TInVar, TRet> func,

			Param.Call<TInExpr, TRet1> func1
		)
			where func:ExprAsMemberI<TInExpr>, VarAsPropI<TInVar>
			
		{

			var funcVar = (func as VarAsPropI<TInVar>).var; 

			var funcRet = func.ret;

			var funcExpr = (func as ExprAsMemberI<TInExpr>).expr;
			var func1applied = func1.apply(funcExpr);

			var func1Var = (func1 as VarAsPropI<TInExpr>).var;




			return Param.Eval(
				(func as VarAsPropI<TInVar>).var, 


				func.ret
				,
				func1.apply(func.expr)

				(func1.ret as Substitute2NewI<TRet1>).substitute2new( (func1 as VarAsPropI<TInExpr>).var ,(func as ExprAsMemberI<TInExpr>).expr)
				,


				new Binary<TInVar1, TInVar_2_1, TInExpr_1>(
					func.var1
					,
					func1.var1
					,
					func1.apply(func.expr).expr
				)
			);

			throw new NotImplementedException();
		}




	}
}
