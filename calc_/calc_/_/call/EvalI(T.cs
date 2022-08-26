using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call
{
	public partial interface EvalI<out T>
		
	{

		T eval();
	}
}
