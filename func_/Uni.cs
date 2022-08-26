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


namespace nilnul.obj.func_
{


	public class Uni :
		obj.func.be_.uni.vow.Ee
		,
		F
		,
		IUni
	{
		public Uni(F val) : base(val)
		{
		}

		public Uni(obj.Func3 val) : base(val)
		{
		}

		public Uni(LambdaExpression p) : this(new obj.Func3(p))
		{
		}

		public Ee flat => base.ee.flat;
	}
}
