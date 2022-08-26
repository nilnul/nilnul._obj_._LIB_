using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.nary_
{

	[Obsolete(nameof(calc_.Nary))]
	public class OfExpr : nilnul.obj.Box1<obj.ExprI4>, NaryI
	{

		

		public OfExpr(
			obj.ExprI4 expr
		):base(
			(expr)
		)
		{

		}

		public FuncI3 calc()
		{
			return  nilnul.obj.func_._NaryX.Func(
				boxed
			);
			;
		}
	}


}
