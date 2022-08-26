using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op;

namespace nilnul.obj.op.binary.closed
{


	public class Args<T> :

		op.Call_ArgArg1A<T,T>
	{

		public Args(T arg, T arg1)
			:base(arg,arg1)
		{

		}

	}
}
