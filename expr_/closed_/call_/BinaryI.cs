using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed_.call_
{
	public class Binary<T> :
		nilnul.obj._call_.OpArgArg1A<
			nilnul.obj.op_.BinaryI<T>,
			expr_.ClosedI<T>,
			expr_.ClosedI<T>
		>
		,
		nilnul.obj.expr_.closed_.CallI<T>

		
	{
		public Binary(nilnul.obj.op_.BinaryI<T> op,nilnul.obj.expr_.ClosedI<T> arg,nilnul.obj.expr_.ClosedI<T> arg1) : base(op,arg,arg1)
		{
		}

		public obj.var.SetI2<T> vars => new obj.var.Set2<T>(
			this.arg.vars.Concat(this.arg1.vars)
		);

		public ClosedI<T> substitute(VarI6<T> var, ClosedI<T> expr)
		{
			return new Binary<T>(
				this.op
				,
				this.arg.substitute(var,expr)
				,
				this.arg.substitute(var,expr)
			)
			;
		}
	}

	
	


}
