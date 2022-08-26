using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._unary_
{
	public abstract class OpArgA1<TOp, TArg> : nilnul.obj._call_.OpA2<TOp>, ArgI<TArg>
		
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public OpArgA1(TOp op,TArg arg) : base(op)
		{
			_arg = arg;
		}
	}
}
