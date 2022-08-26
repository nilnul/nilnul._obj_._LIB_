using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.binary
{


	public class Const<P1,P2,R> :
		OpArgArg1A<BinaryI<P1, P2, R>, ConstI<P1>, ConstI<P2>>
		, ConstI<R>
	{

		public Const(
			BinaryI<P1, P2, R> op
			,
			ConstI<P1> arg
			, ConstI<P2> arg1

			)
			: base(op, arg, arg1)
		{

		}

		public R eval()
		{
			return op.eval(arg.eval(), arg1.eval());
			throw new NotImplementedException();
		}
	}
}
