using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op;

namespace nilnul.obj.op.binary.closed
{


	public class Const<T> :

		binary.Const<T,T,T>
	{

		public Const(
			BinaryI<T, T, T> op
			,
			ConstI<T> arg
			,
			ConstI<T> arg1

		)
			: base(op, arg, arg1)
		{

		}

	}
}
