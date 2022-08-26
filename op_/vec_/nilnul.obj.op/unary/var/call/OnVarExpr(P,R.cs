using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.var.call
{
	public partial class OnVarExpr<P,R>
		:nilnul.obj.op.var.call.OnVarExprI<R>
	{
		private op.unary.VarI<P,R> _op;

		public op.unary.VarI<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		private nilnul.obj.op.var.call.OnVarExprI<P> _para;

		public nilnul.obj.op.var.call.OnVarExprI<P> para
		{
			get { return _para; }
			set { _para = value; }
		}
		public OnVarExpr(op.unary.VarI<P,R> op, nilnul.obj.op.var.call.OnVarExprI<P> para)
		{
			this._op = op;
			this._para = para;

		}
		//public OnVarExpr(
		//	Func<P,R> func,P para	
		//)
		//	:this(new Unary<P,R>(func), new nilnul.obj.op.var.call.Literal<P>( para))
		//{

		//}

	
		
		
	}
}
