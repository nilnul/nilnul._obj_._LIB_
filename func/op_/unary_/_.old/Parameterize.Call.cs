using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Param
	{
		public class Call<TParam, TRetParam,TRetRet>
			:FuncI1<TParam,FuncI<TRetParam,TRetRet>>
		{
			private nilnul.obj.VarI3<TParam> _var;

			public nilnul.obj.VarI3<TParam> var
			{
				get { return _var; }
				set { _var = value; }
			}

			private FuncI<TRetParam,TRetRet> _ret;

			public FuncI<TRetParam,TRetRet> ret
			{
				get { return _ret; }
				set { _ret = value; }
			}

			public Call(obj.Var3<TParam> var, FuncI<TRetParam,TRetRet> func)
			{
				_var = var;
				_ret = ret;

			}





			public FuncI<TRetParam, TRetRet> rule
			{
				get {
					return _ret;
					
					throw new NotImplementedException(); 
				
				}
			}

			public VarI3<TParam> param
			{
				get {
					return _var;
					
					throw new NotImplementedException(); 
				}
			}

			

			public void reduce()
			{
				_ret.reduce();
				return;
				throw new NotImplementedException();
			}

			//void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			//{
			//	_ret.substitute(var, expr);
			//	return;
			//	throw new NotImplementedException();
			//}

			public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{
				_ret.substitute(var, expr);
				return;
				throw new NotImplementedException();
			}
		}
	}
}
