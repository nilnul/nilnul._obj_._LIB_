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
	

	public class Binary :
		nilnul.obj.calc_.Binary<obj.FuncI3>
		,
		func.CalcI
	{
		public Binary(BinaryI<FuncI3> op, CalcI<FuncI3> arg, CalcI<FuncI3> arg1) : base(op, arg, arg1)
		{
		}

		

		public Binary(BinaryI<FuncI3> op,LambdaExpression val,LambdaExpression val1) :
			this(
				op
				,
				new calc_.Lamda(val)
				,
				new calc_.Lamda(val1)

			)
		{
		}


		//public LambdaExpression lambda =>this.calc().flat.ee;
	}
}
