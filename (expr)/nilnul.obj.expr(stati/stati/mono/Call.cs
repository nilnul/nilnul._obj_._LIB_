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

namespace nilnul.obj.expr.stati.mono
{
	public class Call<T>
		: Call<obj.mono.OpI<T>, T>
	{

		public Call(obj.mono.OpI<T> op, StatiI<T> arg) : base(op, arg)
		{

		}


	}


	public class Call<TOp, T>

		:
		Call<TOp, T, T>
		where TOp : obj.mono.OpI<T>

	{
		public Call(TOp op, obj.expr.StatiI<T> arg) : base(op, arg)
		{

		}



	}

	public class Call<TOp, TR, TP>
		:
		Call<TOp, TR, TP, obj.expr.StatiI<TP>>

		,
		StatiI<TR>

		where TOp : obj.mono.OpI<TP, TR>

	{

		public Call(TOp op, obj.expr.StatiI<TP> arg) : base(op, arg)
		{

		}


	




	}

	public class Call<TOp, TR, TP, TExpr>
		:
		CallA<TOp, TExpr>
		,
		StatiI<TR>
		,obj.call._call.OpI

		where TOp : obj.mono.OpI<TP, TR>
		where TExpr : obj.expr.StatiI<TP>

	{

		public Call(TOp op, TExpr arg) : base(op, arg)
		{

		}

		public nilnul.obj.var.stati.Set vars
		{
			get
			{
				return arg.vars;

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

			if (argReduced is no._call.EvalI<TP>)
			{
				var casted = argReduced as no._call.EvalI<TP>;
				return new no.Call<TR>(op.eval(
					casted.eval()
				));

			}
			else
			{
				return new Call<TOp, TR, TP>(
					op, argReduced
				);
			}


			throw new NotImplementedException();
		}

		public StatiI<TR> substitute<V>(Stati<V> var, StatiI<V> expr)
		{

			var argSubsituted = arg.substitute<V>(var, expr);
			return new Call<TOp, TR, TP>(
				op, argSubsituted
			);


			throw new NotImplementedException();
		}
	}


}
