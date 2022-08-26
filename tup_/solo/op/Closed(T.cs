using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.mono.op
{
	public partial class Closed<T>
		:
		nilnul.obj.mono.Op<T,T>
		,
		
		ClosedI<T>
	{
		
		public Closed(System.Func<T, T> func)
			:base(func)
		{

		}



	}
}
