using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.rel
{
	public partial class Closed<T>
		:nilnul.obj.Rel<T,T>
		,
		nilnul.obj.rel.ClosedI<T>
	{
		public Closed(Func<T,T,bool> func)
			:base(func)
		{

		}

		
	}
}
