using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._expr;
using nilnul.obj._expr._members;
using nilnul.obj._var;
using nilnul.obj.var.set;

namespace nilnul.obj.expr.mono
{
	/// <summary>
	/// op statically typed on arg dynamically typed
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	public partial class Call<P, R>
		:
		nilnul.obj.mono.CallA<obj.mono.OpI<P, R>, _expr.ExprI_dynamic>
		,
		_expr.ExprI_dynamic
	{
		public Type type
		{
			get
			{
				return typeof(R);
				throw new NotImplementedException();
			}
		}

		public HashSet<_var.VarI_dynamicTyped> vars
		{
			get
			{
				return arg.vars;
				throw new NotImplementedException();
			}
		}



		public Call(
				obj.mono.OpI<P, R> op
				,
				_expr.ExprI_dynamic arg
			)
				: base(op, arg)
		{
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg.type, typeof(R));
		}



		public _expr.ExprI_dynamic reduce()
		{
			var argDemoted = arg.reduce();

			if (argDemoted is _expr.FormI)
			{
				return new _expr.Form<R>(

					new nilnul.obj.form.mono.Call_argDynamic<P,R>(

								op,

							(argDemoted as _expr.FormI).form 
						
					)

				);

			}

			return new Call<P, R>(



						op,

						argDemoted


				);
			throw new NotImplementedException();
		}



		public ExprI_dynamic substitute(VarI_dynamicTyped var, ExprI_dynamic expr)
		{

			return new Call<P, R>(op, arg.substitute(var, expr));

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{this.op.ToString()}({this.arg.ToString()})";
        }
	}
}
