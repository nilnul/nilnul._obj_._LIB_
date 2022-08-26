using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class Null
	{
		static public void AssertNotNull(object x) {
			if (x is null)
			{
				throw new ArgumentNullException();
				
			}
		}
	}
}
