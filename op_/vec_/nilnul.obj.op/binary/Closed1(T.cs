using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.binary
{
	public partial class Closed1<T>
		:nilnul.obj.op.Binary<T,T,T>
		,
		ClosedI<T>
	{
		static public Closed1<int> intPlus = new Closed1<int>((x, y) => x + y,"+");
		
		public Closed1(Func<T,T,T> func)
			:base(func)
		{
			

		}

		public Closed1(Func<T,T,T> func,string name)
			:base(func,name)
		{
			

		}
	
	}
}
