using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_
{
	public interface IClosed : IFunc { }

	public class Closed :
		obj.func.calc_.lamda.be_.closed.vow.Ee
		//,
		//func.calc_.LamdaI
		,
		IClosed
	{
		public Closed(LambdaExpression val) : base(val)
		{
		}

		public LambdaExpression lambda =>this.ee;
	}
}
