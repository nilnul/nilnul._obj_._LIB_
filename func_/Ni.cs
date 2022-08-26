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

	/// <summary>
	/// 
	/// </summary>
	/// avoid using Nary, as this means the count of pars.

	public class Ni :
		obj.func.be_.ni.vow.Ee
		,
		F
	{
		public Ni(F val) : base(val)
		{
		}
		public Ni(obj.Func3 val) : base(val)
		{
		}

		public Ni(LambdaExpression val) : this(new obj.Func3(val) )
		{
		}

		public Ni(
			nilnul.obj.ExprI4 expr
		):this(
			LambdaExpression.Lambda(expr.expr)
		)
		{

		}

		public Ee flat => base.ee.flat;
	}
}
