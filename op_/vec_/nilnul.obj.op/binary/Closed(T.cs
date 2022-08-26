using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.binary
{
	public partial class Closed<T>
		:
		nilnul.obj.op.Binary<T,T,T>
		,
		
		ClosedI<T>
	{
		
		public Closed(Func<T,T,T> func)
			:base(func)
		{

		}



	}
}
