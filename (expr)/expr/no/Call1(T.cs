using nilnul.obj._expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._var;


namespace nilnul.obj.expr.no
{
	public  class Call1<T,TOp>

		:
		nilnul.obj.no._call_.EvalA<T>
		,
		nilnul.obj.ExprI3<T>

	{


		public Call1(T val):base(val)
		{

		}
	
	}
}
