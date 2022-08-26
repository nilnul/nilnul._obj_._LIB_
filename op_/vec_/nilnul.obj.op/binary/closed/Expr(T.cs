using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op;

namespace nilnul.obj.op.binary.closed
{


	public class Expr<T> :

		binary.Expr<T,T,T>
	{

		public Expr(
			BinaryI<T, T, T> op
			,
			ExprI3<T> arg
			,
			ExprI3<T> arg1

		)
			: base(op, arg, arg1)
		{

		}

	}
}
