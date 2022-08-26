using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.call
{
	public partial class OnVarExpr<P,R>
		:nilnul.obj.op.var.call.OnVarExprI<R>
	{
		private op.UnaryI<P,R> _op;

		public op.UnaryI<P,R> op
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
		public OnVarExpr(Unary<P,R> op, nilnul.obj.op.call.ExprI<P> para)
		{
			this._op = op;
			this._para = para;

		}
		public OnVarExpr(
			System.Func<P, R> func,P para	
		)
			:this(new Unary<P,R>(func), new nilnul.obj.op.call.Literal<P>( para))
		{

		}

	
		
		
	}
}
