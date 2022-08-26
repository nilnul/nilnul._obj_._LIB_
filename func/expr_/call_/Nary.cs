using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_.call_
{


	public class Nary :
		nilnul.obj.expr_.typed_.generi_.call_.Nary<FuncI3>
		,
		NaryI
	{
		public Nary(NaryI<obj.FuncI3> op) : base(op)
		{
		}

		public Nary(obj.FuncI3 r) : this( new obj.func.op_.Nary(r) )
		{
		}

		public Nary(
			obj.ExprI4 expr
		):this(
			new func_.Ni(expr)
		)
		{

		}

		//public ConstantExpression asConstant() {
		//	return Expression.Constant(op.op());
		//}

		//public Ee<FuncI3> generi => new Ee<FuncI3>(
		//	( new nilnul.obj.Expr4(
		//		Expression.Constant(op.op())
		//	))
		//);

		//public Ee expr =>
		//	//generi.ee.expr;
		// new Ee( asConstant() );
	}


}
