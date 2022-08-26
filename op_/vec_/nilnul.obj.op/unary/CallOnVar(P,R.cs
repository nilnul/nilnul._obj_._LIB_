using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public partial class CallOnVar<P,R>

	{
		private op.Unary<P,R> _op;

		public op.Unary<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		private VarI<P> _para;

		public VarI<P> para
		{
			get { return _para; }
			set { _para = value; }
		}
		public CallOnVar(Unary<P,R> op, VarI<P> para)
		{
			this._op = op;
			this._para = para;

		}

		public CallOnVar(
			System.Func<P, R> func,VarI<P> para	
		)
			:this(new Unary<P,R>(func),para)
		{

		}

		
		
	}
}
