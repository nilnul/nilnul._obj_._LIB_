using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{
	/// <summary>
	/// no vars.
	/// </summary>
	public class Calc
		:
		expr.be_.calc.vow.Ee
		,
		ExprI4

		,
		nilnul.obj.ICalc
		
	{
		public Calc(ExprI4 val) : base(val)
		{
		}

		public object calc() {

			return System.Linq.Expressions.Expression.Lambda<Func<object> >(this.ee.expr.ee).Compile()();
			
		}


		public Ee expr => this.ee.expr;
	}
}
