using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed_.call_
{
	[Obsolete()]
	public class Unary<T> :
		nilnul.obj._call_.OpArgA<nilnul.obj.op_.UnaryI<T>, ClosedI<T>>
		,
		nilnul.obj.expr_.closed_.CallI<T>


	{
		public Unary(op_.UnaryI<T> op, ClosedI<T> arg) : base(op, arg)
		{
		}

		public obj.var.SetI2<T> vars => this.arg.vars;

		public ClosedI<T> substitute(VarI6<T> var, ClosedI<T> expr)
		{
			return new Unary<T>(
				this.op
				,
				this.arg.substitute(var,expr)
			);
		}
	}



}
