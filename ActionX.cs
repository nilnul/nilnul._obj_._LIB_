using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj
{
	public partial class ActionX
	{
		static public void Eval(Action a) {
			if (!(a     is null))
			{
				a();
			}
		
		}
	}
}
