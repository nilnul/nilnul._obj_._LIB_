using nilnul.obj._expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.duo
{
	public class Call
		:ExprI_blank
	{
		private ExprI_blank _arg;

		public ExprI_blank arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		private ExprI_blank _arg1;

		public ExprI_blank arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}





		

	}
}
