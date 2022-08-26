using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.duo.op_.froFunc_
{
	public partial class Closed<P1>
		:duo.FuncAsOp<P1,P1,P1>
	{

		

		
		public Closed(Func<P1,P1,P1> func):base(func)
		{
		}

		
	}
}
