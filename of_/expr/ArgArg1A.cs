using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.expr
{
	public partial class ArgArg1A<TArg,TArg1>
		:ArgA<TArg>
	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}

		public ArgArg1A(TArg arg,TArg1 arg1)
			:base(arg)
		{
			this._arg1 = arg1;

		}
		
	}
}
