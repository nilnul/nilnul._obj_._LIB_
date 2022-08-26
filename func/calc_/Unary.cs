using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_
{
	

	public class Unary :
		nilnul.obj.calc_.Unary<obj.FuncI3>
		,
		func.CalcI
		,
		obj.calc_.UnaryI<obj.FuncI3>
	{

		public Unary(UnaryI<FuncI3> op, CalcI<FuncI3> arg) : base(op, arg)
		{
		}

		public Unary(UnaryI<FuncI3> op,LambdaExpression val) :
			this(
				op
				,
				new calc_.Lamda(val)
			)
		{
		}

		//public LambdaExpression lambda =>this.calc().flat.ee;
	}
}
