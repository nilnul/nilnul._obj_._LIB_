using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.closed_.generi_
{
	

	public class Uni<T> :
		obj.func.calc_.lamda_.closed_.generi.be_.uni.vow.Ee<T>
		//,
		//func.calc_.LamdaI
	{
		public Uni(Generi<T> val) : base(val)
		{
		}

		public Uni(Expression<Func<T, T>> expression):this(new Generi<T>(expression) )
		{
		}

		public LambdaExpression lambda =>this.ee.ee.ee;
	}
}
