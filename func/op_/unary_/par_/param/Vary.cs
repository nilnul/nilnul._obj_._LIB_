using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.mono.op
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// don't use "Param" for "Param" is a reserved token
	public class Vary
	{
		static public Call<TInVar, TRet> Eval<TInVar, TRet>(obj.VarI3<TInVar> var
			,
			TRet ret
			) 
			where TRet : SubstituteI, ReduceI,Substitute2NewI<TRet>,Reduce2newI<TRet>,BoundVarsI


		{

			///var must be free.
			///
			if (ret.boundVars.Contains(var))
			{

				throw new ParamBoundVarException();
				
			}

			return new Call<TInVar, TRet>(var, ret);
		
		}

		static public _func.FuncI_dynamic Eval(_func.FuncI_dynamic func, Type type) {

			return new _func.Func(
				obj.var.set.Ordered.AppendNew(func.vars,type)
				,

				func.expr	
			);
			throw new NotImplementedException();
		}

		static public _func.FuncI_dynamic Eval(_func.FuncI_dynamic func, _var.VarI_dynamicTyped var) {

			return new _func.Func(
				obj.var.set.ordered.ExtensionMethods.Prepend(func.vars,var)
				,

				func.expr	
			);
			throw new NotImplementedException();
		}
		static public _func.FuncI_dynamic Eval(_expr.ExprI_dynamic expr, _var.VarI_dynamicTyped var) {

			return new _func.Func(
				new obj.var.set.Ordered(var)
				,

				expr	
			);
			throw new NotImplementedException();
		}

		static public Call<TInVar, Nullary<T>>   Eval<TInVar, T>(obj.VarI3<TInVar> var
			,

			obj.expr.ExprI<T> expr
			) 


		{
			return Eval(var, new func.Nullary<T>(expr ));
		
		}

		[Serializable]
		public class ParamBoundVarException : Exception
		{
			public ParamBoundVarException() { }
			public ParamBoundVarException(string message) : base(message) { }
			public ParamBoundVarException(string message, Exception inner) : base(message, inner) { }
			protected ParamBoundVarException(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context)
				: base(info, context) { }
		}
		public partial class Call<TInVar, TRet>
			:
			ApplyA<TInVar,TRet>
			,
			func.FuncI<TInVar, TRet>
			,ApplyI<TInVar,TRet>
			,Substitute2NewI<Call<TInVar,TRet>>
			,Reduce2newI<Call<TInVar,TRet>>
			,BoundVarsI
			,
			RetReplaceI

			where TRet : SubstituteI, ReduceI,Substitute2NewI<TRet>,Reduce2newI<TRet>,BoundVarsI
			
			//,ExprReplaceI

		{
			#region static

			#endregion
			private obj.VarI3<TInVar> _var;

			public obj.VarI3<TInVar> var
			{
				get { return _var; }
				set { _var = value; }
			}

			private TRet _ret;

			public TRet ret
			{
				get { return _ret; }
				set { _ret = value; }
			}

			public Call(obj.VarI3<TInVar> var, TRet ret)
			{
				_var = var;
				_ret = ret;
			}



			public override string ToString()
			{
				return string.Format("{0}{1}{2}",_var,FuncX.GoesTo,_ret);
			}

			public void reduce()
			{
				ret.reduce();
				return;
				throw new NotImplementedException();
			}

			public void substitute(VarI3<TInVar> var, expr.ExprI<TInVar> expr)
			{
				ret.substitute(var, expr);
				return;
				throw new NotImplementedException();
			}

			public void bind(expr.ExprI<TInVar> arg)
			{
				_ret.substitute(_var, arg);
				return ;
				throw new NotImplementedException();
			}

			public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				ret.substitute(var, expr);
				return;

				throw new NotImplementedException();
			}

			public override TRet apply(expr.ExprI<TInVar> arg)
			{
				return ret.substitute2new(_var, arg);
				throw new NotImplementedException();
			}

			public Call<TInVar, TRet> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				return new Call<TInVar, TRet>(_var, ret.substitute2new(var, expr));
				throw new NotImplementedException();
			}

			public Call<TInVar, TRet> reduce2new()
			{
				return new Call<TInVar, TRet>(_var, _ret.reduce2new());
				throw new NotImplementedException();
			}

			public HashSet<VarI1> boundVars
			{
				get { 
					var r=ret.boundVars;
					r.UnionWith( new []{_var});
					return r;
					throw new NotImplementedException(); 
				
				}
			}

			public FuncI<TInVar, TFuncAsRet> retReplace< TFuncAsRet>(TFuncAsRet funcAsRet)
			where TFuncAsRet : SubstituteI, ReduceI, Substitute2NewI<TFuncAsRet>, Reduce2newI<TFuncAsRet>, BoundVarsI
				//,ExprReplaceI
			{
				return new Call<TInVar, TFuncAsRet>(var, funcAsRet);

				throw new NotImplementedException();
			}
			public FuncI<TInVar,TRet_func> retReplace<TInVar_arg, TRet_arg, TRet_func>(TRet_func funcAsRet)
				where TRet_func:FuncI<TInVar_arg,TRet_arg>
				, Substitute2NewI<TRet_func>
				,Reduce2newI<TRet_func>
				//,ExprReplaceI

			{
				return retReplace<TRet_func>(funcAsRet);

				throw new NotImplementedException();
			}
		//	public FuncI<TInVar, TRetReplaced> exprReplace<TInVar_OfArg, TRet_OfArg, TArg, TRetReplaced>(FuncI<TInVar_OfArg, TRet_OfArg> arg)
		//		where TArg:FuncI<TInVar_OfArg,TRet_OfArg>
		//		, Substitute2NewI<TArg>
		//		,Reduce2newI<TArg>
		//		,ExprReplaceI<TInVar_OfArg>
		//		where TRet_OfArg:ExprReplaceI<TInVar_OfArg>
		//	{
		////		return retReplace(ret.exprReplace(arg));
		//		return Eval(var,ret.exprReplace<TRet_func>(arg));

		//		throw new NotImplementedException();
		//	}

		



			FuncI<TInVar, TRet> Substitute2NewI<FuncI<TInVar, TRet>>.substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				return substitute2new(var,expr);
				throw new NotImplementedException();
			}

			FuncI<TInVar, TRet> Reduce2newI<FuncI<TInVar, TRet>>.reduce2new()
			{
				return reduce2new();
				throw new NotImplementedException();
			}

			public FuncI<TInVar, TFuncAsRet> retReplace<TInVar, TFuncAsRet>(TFuncAsRet funcAsRet)
			{

				throw new NotImplementedException();
			}
		}
	}
}
