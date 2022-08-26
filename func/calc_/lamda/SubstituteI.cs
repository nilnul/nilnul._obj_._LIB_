using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial interface SubstituteI
	{

		void substitute<V>(nilnul.obj.VarI2<V> var, nilnul.obj.expr.ExprI<V> expr);


	}
}
