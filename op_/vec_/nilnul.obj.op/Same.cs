using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	public partial class Same
	{
		static public bool Eval(ref object a,ref object b) {
			return object.Equals(a, b);
		}
	}
}
