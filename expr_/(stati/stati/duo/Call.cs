using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.enumerable.b;
using nilnul.obj._form;
using nilnul.obj._form._members;
using nilnul.obj.call._call;
using nilnul.obj.var;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr.stati.duo
{
	public class Call<T>
		: Call<obj.duo.OpI<T>, T>
	{

		public Call(obj.duo.OpI<T> op, obj.expr.StatiI<T> arg,obj.expr.StatiI<T> arg1) : base(op, arg,arg1)
		{

		}


	}


	public class Call<TOp, T>

		:
		Call<TOp, T, T,T>
		where TOp : obj.duo.OpI<T>

	{
		public Call(TOp op, obj.expr.StatiI<T> arg ,obj.expr.StatiI<T> arg1) : base(op, arg,arg1)
		{

		}



	}

	public class Call<TOp, TR, TP,TP1>
		:
		Call<TOp, TR, TP,TP1, obj.expr.StatiI<TP> , obj.expr.StatiI<TP1>>

		,
		StatiI<TR>

		where TOp : obj.duo.OpI<TP,TP1, TR>

	{

		public Call(TOp op, obj.expr.StatiI<TP> arg, obj.expr.StatiI<TP1> arg1) : base(op, arg,arg1)
		{

		}


	




	}

	public class Call<TOp, TR, TP, TP1, TExpr, TExpr1>
		:
		CallA<TOp, TExpr,TExpr1>
		,
		StatiI<TR>
		,nilnul.obj.call._call.OpI

		where TOp : obj.duo.OpI<TP,TP1, TR>
		where TExpr : obj.expr.StatiI<TP>
		where TExpr1 : obj.expr.StatiI<TP1>


	{

		public Call(TOp op, TExpr arg,TExpr1 arg1) : base(op, arg,arg1)
		{

		}

		public obj.var.stati.Set vars
		{
			get
			{
				var r = new obj.var.stati.Set();
				r.UnionWith(arg.vars);
				r.UnionWith(arg1.vars);
				return  r ;

				throw new NotImplementedException();
			}
		}

		OpI call._call.OpI.op
		{
			get
			{
				return this.op;
				throw new NotImplementedException();
			}
		}

		public StatiI<TR> reduce()
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

		public StatiI<TR> substitute<V>(Stati<V> var, StatiI<V> expr)
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
			if (arg is VarAsStatiI)
			{
				//argStr = arg.ToString();
			}
			else 
			{
				var argOpCasted = (arg as nilnul.obj.call._call.OpI).op;
				if (obj.op.Priority.StaticInstance.Lt(op,argOpCasted))
				{
                }
				else
				{
					argStr = $"({argStr})";

				}

			}

			string arg1Str=arg1.ToString();
			if (arg1 is VarAsStatiI)
			{
				//argStr = arg.ToString();
			}
			else 
			{
				var arg1OpCasted = ((nilnul.obj.call._call.OpI)arg1).op;
				if (obj.op.Priority.StaticInstance.Lt(op,arg1OpCasted))
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
