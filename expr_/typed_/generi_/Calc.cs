using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using s = System.Linq.Expressions;


namespace nilnul.obj.expr_.typed_.generi_
{

	



	static public class _CalcX 
	{
		static public T _Calc_assumeNoVar<T>(this System.Linq.Expressions.Expression _form)
		{
			return  s.Expression.Lambda<Func<T> >(_form).Compile()();

		}


	}
}
