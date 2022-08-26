﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Param
	{

		public partial class Call<TInVar, TRet, TInExpr>
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

			where TRet : SubstituteI, ReduceI,Substitute2NewI<TRet>,Reduce2newI<TRet>,BoundVarsI,ExprReplaceI
				,
				CompoI<TInVar,TInExpr>

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
			where TFuncAsRet : SubstituteI, ReduceI, Substitute2NewI<TFuncAsRet>, Reduce2newI<TFuncAsRet>, BoundVarsI,ExprReplaceI
			{
				return new Call<TInVar, TFuncAsRet>(var, funcAsRet);

				throw new NotImplementedException();
			}
			public FuncI<TInVar,TRet_func> retReplace<TInVar_arg, TRet_arg, TRet_func>(TRet_func funcAsRet)
				where TRet_func:FuncI<TInVar_arg,TRet_arg>
				, Substitute2NewI<TRet_func>
				,Reduce2newI<TRet_func>
				,ExprReplaceI

			{
				return retReplace<TRet_func>(funcAsRet);

				throw new NotImplementedException();
			}
			public FuncI<TInVar, TRetReplaced> exprReplace<TInVar_OfArg, TRet_OfArg, TArg, TRetReplaced>(FuncI<TInVar_OfArg, TRet_OfArg> arg)
				where TArg:FuncI<TInVar_OfArg,TRet_OfArg>
				, Substitute2NewI<TArg>
				,Reduce2newI<TArg>
				,ExprReplaceI<TInVar_OfArg>
				where TRet_OfArg:ExprReplaceI<TInVar_OfArg>
			{
		//		return retReplace(ret.exprReplace(arg));
				return Eval(var,ret.exprReplace<TRet_func>(arg));

				throw new NotImplementedException();
			}

			public FuncI<TInVar> compo<TRet_arg>( FuncI<TInExpr,TRet_arg> arg) 

			{

				return new Param.Call<TInVar>(
					var
					,
					ret.compo(
						arg
						
					)
					
				);

				throw new NotImplementedException();
			}

			
		}
	}
}
