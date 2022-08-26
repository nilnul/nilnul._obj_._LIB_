using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public abstract partial class Call_op_argA<TOp,TArg>
	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		private TArg _para;

		public TArg para
		{
			get { return _para; }
			set { _para = value; }
		}
		public Call_op_argA(TOp op, TArg para)
		{
			this._op = op;
			this._para = para;

		}
		

		
		
	}
}
