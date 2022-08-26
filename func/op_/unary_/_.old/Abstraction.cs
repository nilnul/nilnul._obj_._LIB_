using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Abstraction
	{

		public class Call<TPara, TFuncParam,TFuncRet>
			:FuncI<TPara,FuncI<TFuncParam,TFuncRet>>

		{
			private nilnul.obj.VarI3<TPara> _param;

			public nilnul.obj.VarI3<TPara> var
			{
				get { return _param; }
				set { _param = value; }
			}

			private FuncI<TFuncParam,TFuncRet> _func;

			public FuncI<TFuncParam,TFuncRet> func
			{
				get { return _func; }
				set { _func = value; }
			}

			public override string ToString()
			{
				return string.Format("{0}{1}{2}",_param,FuncX.GoesTo,func);
			}

			public Call(nilnul.obj.VarI3<TPara> var, FuncI<TFuncParam, TFuncRet> func)
			{
				this._param=var;
				this._func=func;

			}

			public FuncI<TPara, FuncI<TFuncParam, TFuncRet>> substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				return new Call<TPara,TFuncParam,TFuncRet>(
					this._param,
					func.substitute<TArg>(var,expr) as FuncI<TFuncParam,TFuncRet>
				);
				throw new NotImplementedException();
			}

			public FuncI<TFuncParam, TFuncRet> rule
			{
				get {
					return _func;
					
					throw new NotImplementedException(); }
			}

			public VarI3<TPara> param
			{
				get {
					return _param;
					throw new NotImplementedException(); }
			}

			public void reduce()
			{

				_func.reduce();
				return;
				throw new NotImplementedException();
			}
		}
		public class Call<TPara, TInExpr>
			:Call<TPara,Void,Expr<TInExpr>>
		{
			public Call(nilnul.obj.Var3<TPara> var, nilnul.obj.expr.ExprI<TInExpr> func)
				:base( var,new nilnul.obj.func.Expr<TInExpr>(func))
			{

			}


		}
	}
}
