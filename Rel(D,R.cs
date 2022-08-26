using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class Rel<D,R>
		:
		obj.op.Binary<D,R,bool>
		,
		
		RelI<D,R>
	{
		
		
		public Rel(Func<D,R,bool> func)
			:base(func)
		{
			
		}
	
	}
}
