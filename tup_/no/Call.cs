using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.no
{
	public class Call
	{
		private Op _op;

		public Op op
		{
			get { return _op; }
			set { _op = value; }
		}



		public dynamic eval() {
			return _op.eval();
		}
	}
}
