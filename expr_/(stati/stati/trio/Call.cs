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

namespace nilnul.obj.expr.stati.trio
{
	public class Call<T>
		: Call<obj.trio.OpI<T>, T>
	{

		public Call(obj.trio.OpI<T> op, obj.expr.StatiI<T> arg,obj.expr.StatiI<T> arg1,StatiI<T> arg2) : base(op, arg,arg1,arg2)
		{

		}


	}


	public class Call<TOp, T>

		:
		Call<TOp, T, T,T,T>
		where TOp : obj.trio.OpI<T>

	{
		public Call(TOp op, obj.expr.StatiI<T> arg ,obj.expr.StatiI<T> arg1, StatiI<T> arg2) : base(op, arg,arg1,arg2)
		{

		}



	}

	public class Call<TOp, TR, TP,TP1,TP2>
		:
		Call<TOp, TR, TP,TP1, TP2,obj.expr.StatiI<TP> , obj.expr.StatiI<TP1> , obj.expr.StatiI<TP2>>

		,
		StatiI<TR>

		where TOp : obj.trio.OpI<TP,TP1,TP2, TR>

	{

		public Call(TOp op, obj.expr.StatiI<TP> arg, obj.expr.StatiI<TP1> arg1  ,StatiI<TP2> arg2) : base(op, arg,arg1,arg2)
		{

		}


	




	}

	public class Call<TOp, TR, TP, TP1,TP2, TExpr, TExpr1,TExpr2>
		:
		CallA<TOp, TExpr,TExpr1,TExpr2>
		,
		StatiI<TR>
		,nilnul.obj.call._call.OpI

		where TOp : obj.trio.OpI<TP,TP1,TP2, TR>
		where TExpr : obj.expr.StatiI<TP>
		where TExpr1 : obj.expr.StatiI<TP1>
		where TExpr2 : obj.expr.StatiI<TP2>


	{

		public Call(TOp op, TExpr arg,TExpr1 arg1,TExpr2 arg2) : base(op, arg,arg1,arg2)
		{

		}

		public obj.var.stati.Set vars
		{
			get
			{
				var r = new obj.var.stati.Set();
				r.UnionWith(arg.vars);
				r.UnionWith(arg1.vars);
				r.UnionWith(arg2.vars);
				return  r ;

				throw new NotImplementedException();
			}
		}

		OpI call._call.OpI.op
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public StatiI<TR> reduce()
		{

			var argReduced = arg.reduce();
			var arg1reduced = arg1.reduce();
			var arg2reduced = arg2.reduce();

			if (argReduced is no._call.EvalI<TP> && arg1reduced is no._call.EvalI<TP1>  && arg2reduced is no._call.EvalI<TP2>)
			{
				var casted = argReduced as no._call.EvalI<TP>;
				var casted1 = arg1reduced as no._call.EvalI<TP1>;
				var casted2 = arg2reduced as no._call.EvalI<TP2>;

				return new no.Call<TR>(op.eval(
					casted.eval()
					,casted1.eval(),casted2.eval()
				));

			}
			else
			{
				return new Call<TOp,TR, TP,TP1,TP2>(
					op, argReduced,arg1reduced,arg2reduced
				);
			}


			throw new NotImplementedException();
		}

		public StatiI<TR> substitute<V>(Stati<V> var, StatiI<V> expr)
		{

			var argSubsituted = arg.substitute<V>(var, expr);
			var arg1substitued = arg1.substitute<V>(var, expr);
			var arg2substitued = arg2.substitute<V>(var, expr);

			return new Call<TOp, TR, TP,TP1,TP2>(
				op, argSubsituted,arg1substitued,arg2substitued
			);


			throw new NotImplementedException();
		}
	}


}
