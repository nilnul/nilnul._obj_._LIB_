using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.binary
{



	public class Expr<P1,P2,R>
		:
		OpArgArg1A<BinaryI<P1, P2, R>, ExprI3<P1>, ExprI3<P2>>
		,
		ExprI3<R>
	{

		public Expr(BinaryI<P1, P2, R> op, ExprI3<P1> p1, ExprI3<P2> arg2)
			: base(op, p1, arg2)
		{
		}

	}



}
