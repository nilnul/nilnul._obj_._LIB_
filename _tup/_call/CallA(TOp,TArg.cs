using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._tuple._call
{
	public abstract class CallA<TOp,TArg>
		:OpA<TOp>
	{

		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


		public CallA(TOp op,TArg arg)
			:base(op)
		{
			_arg = arg;

		}


	}
}
