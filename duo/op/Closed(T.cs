using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.duo.op
{
	public partial class Closed<T>
		:
		nilnul.obj.duo.op.FuncAsOp<T,T,T>
		,
		
		ClosedI<T>
	{
		
		public Closed(Func<T,T,T> func)
			:base(func)
		{

		}



	}
}
