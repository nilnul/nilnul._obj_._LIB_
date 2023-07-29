using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.op.binary
{
	public partial class Call<P, P1, R>
		:
		nilnul.obj.op.Call_OpArgArg1A<obj.op.BinaryI<P, P1, R>, ExprI<P>, ExprI<P1>>
		,
		ExprI<R>
	{
		public Call(
			obj.op.BinaryI<P, P1, R> op
			,
			ExprI<P> arg
			,
			ExprI<P1> arg1
		)
			: base(op, arg, arg1)
		{

		}


		public ExprI<R> substitute<V>(VarI3<V> var, ExprI<V> expr)
		{
			return new Call<P, P1, R>(op, arg.substitute(var, expr), arg1.substitute(var, expr));

			//throw new NotImplementedException();
		}

		public ExprI<R> demote()
		{
			var argDemoted = arg.demote();
			var arg1Demoted = arg1.demote();

			if (argDemoted is FormI && arg1Demoted is FormI)
			{
				return new Call<R>(

					new nilnul.obj.call.op.binary.Call<P, P1, R>(

						op,

						(arg as Call<P>).call
						,
						(arg1 as Call<P1>).call
					)

				);

			}
			return new Call<P,P1,R>(

					op,

					argDemoted
					,
					arg1Demoted
			);

			throw new NotImplementedException();
		}
	}
}
