using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public partial class CallOnExpr<P,R>
		:nilnul.obj.op.call.ExprI<R>
	{
		private op.Unary<P,R> _op;

		public op.Unary<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		private nilnul.obj.op.call.ExprI<P> _para;

		public nilnul.obj.op.call.ExprI<P> para
		{
			get { return _para; }
			set { _para = value; }
		}
		public CallOnExpr(Unary<P,R> op, nilnul.obj.op.call.ExprI<P> para)
		{
			this._op = op;
			this._para = para;

		}
		public CallOnExpr(
			System.Func<P, R> func,P para	
		)
			:this(new Unary<P,R>(func), new nilnul.obj.op.call.Literal<P>( para))
		{

		}

	
		
		
	}
}
