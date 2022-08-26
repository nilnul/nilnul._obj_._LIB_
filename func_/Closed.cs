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
using Fc = nilnul.obj.Func3;


namespace nilnul.obj.func_
{
	public interface IClosed : IFunc { }

	public class Closed :
		obj.func.be_.closed.vow.Ee
		,
		F
		,
		IClosed
	{
		public Closed(F val) : base(val)
		{
		}

		public Closed(Fc val) : base(val)
		{
		}

		public Closed(LambdaExpression p):this(new Fc(p) )
		{
		}

		public Ee flat => this.ee.flat;
	}
}
