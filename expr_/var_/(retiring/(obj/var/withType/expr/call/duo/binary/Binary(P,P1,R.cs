using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.binary
{
	public partial class Closed<T>
		:
		nilnul.obj.expr.Binary< T, T, T>
		,
		ExprI<T>
	{
		public Closed(
			obj.op.BinaryI<T, T, T> op
			,
			ExprI<T> arg
			,
			ExprI<T> arg1
		)
			: base(op, arg, arg1)
		{

		}

		public Closed(
			obj.op.BinaryI<T, T, T> op
			,
			nilnul.obj.VarI3<T> arg
			,
			ExprI<T> arg1
		)
			: base(op, new nilnul.obj.expr.Var<T>( arg), arg1)
		{

		}

		public ExprI<T> substitute<V>(VarI3<V> var, ExprI<V> expr)
		{
			return new Closed<T>(op, arg.substitute(var, expr), arg1.substitute(var, expr));

			//throw new NotImplementedException();
		}

		public ExprI<T> demote()
		{
			var argDemoted = arg.demote();
			var arg1Demoted = arg1.demote();

			if (argDemoted is FormI && arg1Demoted is FormI)
			{
				return new Call<T>(

					new nilnul.obj.call.op.binary.Call<T, T, T>(

						op,

						(argDemoted as Call<T>).call
						,
						(arg1Demoted as Call<T>).call
					).eval()

				);

			}
			return new Closed<T>(

					op,

					argDemoted
					,
					arg1Demoted
			);

			throw new NotImplementedException();
		}
	}
}
