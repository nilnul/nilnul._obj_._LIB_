using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul._call;
using nilnul._op;
using nilnul.enumerable.b;
using nilnul.obj;
using nilnul.obj._form;
using nilnul.obj._form._members;
using nilnul.obj.call._call;
using nilnul.obj.var;
using nilnul.obj.var.stati;

namespace nilnul.expr.duo
{
	public class Call<T>
		: Call<nilnul.duo.OpI<T>, T>
	{

		public Call(nilnul.duo.OpI<T> op, nilnul.ExprI_membered<T> arg, nilnul.ExprI_membered<T> arg1) : base(op, arg,arg1)
		{

		}


	}


	public class Call<TOp, T>

		:
		Call<TOp, T, T,T>
		where TOp : nilnul.duo.OpI<T>

	{
		public Call(TOp op, nilnul.ExprI_membered<T> arg ,nilnul.ExprI_membered<T> arg1) : base(op, arg,arg1)
		{

		}



	}

	public class Call<TOp, TR, TP,TP1>
		:
		Call<TOp, TR, TP,TP1, ExprI_membered<TP> , ExprI_membered<TP1>>

		,
		ExprI_membered<TR>

		where TOp : nilnul.duo.OpI<TP,TP1, TR>

	{

		public Call(TOp op, ExprI_membered<TP> arg, ExprI_membered<TP1> arg1) : base(op, arg,arg1)
		{

		}


	




	}

	public class Call<TOp, TR, TP, TP1, TExpr, TExpr1>
		:
		_call.Call_OpArgArg1A<TOp, TExpr,TExpr1>
		,
		ExprI_membered<TR>
		,nilnul._call.OpI_generic

		where TOp : nilnul.duo.OpI<TP,TP1, TR>
		where TExpr : nilnul.ExprI_membered<TP>
		where TExpr1 : nilnul.ExprI_membered<TP1>


	{
		

		public Call(TOp op, TExpr arg,TExpr1 arg1) : base(op, arg,arg1)
		{

		}

		public var.Set_ofVarI vars
		{
			get
			{
				var r = new nilnul.var.Set_ofVarI();
				r.UnionWith(arg.vars);
				r.UnionWith(arg1.vars);
				return  r ;

				throw new NotImplementedException();
			}
		}

		_op.OpI_generic _call.OpI<_op.OpI_generic>.op
		{
			get
			{
				return this.op;
				throw new NotImplementedException();
			}
		}

		public ExprI_membered<TR> reduce()
		{

			var argReduced = arg.reduce();
			var arg1reduced = arg1.reduce();

			if (argReduced is no._call.EvalI<TP> && arg1reduced is no._call.EvalI<TP1>)
			{
				var casted = argReduced as no._call.EvalI<TP>;
				var casted1 = arg1reduced as no._call.EvalI<TP1>;
				return new no.Call<TR>(op.eval(
					casted.eval()
					,casted1.eval()
				));

			}
			else
			{
				return new Call<TOp, TR, TP,TP1>(
					op, argReduced,arg1reduced
				);
			}


			throw new NotImplementedException();
		}

		public ExprI_membered<TR> substitute<V>(VarI1<V> var, ExprI_membered<V> expr)
		{
			

			var argSubsituted = arg.substitute<V>(var, expr);
			var arg1substitued = arg1.substitute<V>(var, expr);
			return new Call<TOp, TR, TP,TP1>(
				op, argSubsituted,arg1substitued
			);


			throw new NotImplementedException();
		}

		public override string ToString()
		{
			string argStr=arg.ToString();
			if (arg is VarAsExprI)
			{

				//argStr = arg.ToString();
			}
			else 
			{
				var argOpCasted = (arg as nilnul._call.OpI_generic).op;
				if (argOpCasted  is null)
				{
					argStr = $"({argStr})";

				}else
				if (nilnul._op.Priority.StaticInstance.Lt(op,argOpCasted))
				{
                }
				else
				{
					argStr = $"({argStr})";

				}

			}

			string arg1Str=arg1.ToString();
			if (arg1 is VarAsExprI)
			{
				//argStr = arg.ToString();
			}
			else 
			{
				var arg1OpCasted = ((nilnul._call.OpI_generic)arg1).op;
				if (arg1OpCasted is null)
				{
					arg1Str = $"({arg1Str})";

				}else if (nilnul._op.Priority.StaticInstance.Lt(op,arg1OpCasted))
				{
                }
				else
				{
					arg1Str = $"({arg1Str})";

				}

			}




			return  $"{argStr}{op}{arg1Str}";
		}
	}


}
