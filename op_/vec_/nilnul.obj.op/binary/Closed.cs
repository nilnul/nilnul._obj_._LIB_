using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.binary
{
	public partial class Closed
		
	{
		static public Closed1<int> IntPlus = new Closed1<int>((x, y) => x + y, "+");
		static public Closed1<int> IntMinus = new Closed1<int>((x, y) => x - y, "-");
		
		
	
	}
}
