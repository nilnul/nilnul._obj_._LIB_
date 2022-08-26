using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op;

namespace nilnul.obj.duo._call
{


	public class Args_bothSameType<T> :
		nilnul.obj._tuple._call.ArgArg1A<T,T>

		
	{

		public Args_bothSameType(T arg, T arg1)
			:base(arg,arg1)
		{

		}

	}
}
