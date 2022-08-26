using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr_.closed_
{

	public class Variable<T>
		:
		nilnul.obj.Box1<VarI6<T>>
		,
		nilnul.obj.expr_.ClosedI<T>
		,
		_variable_.VarI<VarI6<T>>
	{
		public Variable(VarI6<T> val) : base(val)
		{
		}

		public obj.var.SetI2<T> vars => new obj.var.Set2<T>(this.boxed);

		public VarI6<T> var => this.boxed;

		public ClosedI<T> substitute(VarI6<T> var, ClosedI<T> expr)
		{
			if (var == this.boxed)
			{
				return expr;
			};
			return this;
		}

		
	}



}
