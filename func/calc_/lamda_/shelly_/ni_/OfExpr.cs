using nilnul.obj._func.lamda.be_.flat.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.ni_
{
	public class OfExpr
		: nilnul.obj.Box1<obj.ExprI4>
		,
		obj.FuncI3
	{
		public OfExpr(Expr4 val) : base(val)
		{
		}

		public OfExpr(ExprI4 val) : base(val)
		{
		}

		public Ee flat => new Ee(
			LambdaExpression.Lambda(

			 boxed.expr.ee
			)

		);
	}
}
