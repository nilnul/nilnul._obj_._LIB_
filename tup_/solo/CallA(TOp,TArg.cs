using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.mono
{
	public class CallA<TOp,TArg>
		:nilnul.obj.tuple._call.CallA<TOp,TArg>
	{
		public CallA(TOp op, TArg arg)
			:base(op,arg)
		{

		}
	}
}
