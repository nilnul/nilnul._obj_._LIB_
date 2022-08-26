using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._unary_
{
	public abstract class OpArgA<TOp, TArg> : nilnul.obj._call_.OpA1<TOp>, ArgI<TArg>
		
		where TOp:nilnul.obj._op_.BlankI
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public OpArgA(TOp op,TArg arg) : base(op)
		{
			_arg = arg;
		}
	}
}
