using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.lamda.be_.flat.vow;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func_.closed_.generi_
{
	

	public class Uni<T> :
		obj.func_.closed_.generi.be_.uni.vow.Ee<T>
		,
		F
	{
		public Uni(Generi<T> val) : base(val)
		{
		}

		public Uni(Expression<Func<T, T>> expression):this(new Generi<T>(expression) )
		{
		}

		public Ee flat => base.ee.ee.flat;
	}
}
