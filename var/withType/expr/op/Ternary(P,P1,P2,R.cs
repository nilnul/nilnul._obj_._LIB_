using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial class Ternary<P,P1,P2,R>
		:TernaryI<P,P1,P2,R>
	{
		private nilnul.obj.op.TernaryI<P,P1,P2,R> _op;

		public nilnul.obj.op.TernaryI<P,P1,P2,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Ternary(obj.op.TernaryI<P,P1,P2,R> op )
		{
			this._op = op;
		}

		public ExprI<R> eval(ExprI<P> arg,ExprI<P1> arg1, ExprI<P2> arg2)
		{
			return new Call(op, arg,arg1,arg2);

			throw new NotImplementedException();
		}

		public partial class Call
			:nilnul.obj.op.Call_OpArgArg1Arg2A<
				obj.op.TernaryI<P,P1,P2,R>,
				obj.var.ExprI<P>, 
				obj.var.ExprI<P1>,
				obj.var.ExprI<P2>
			>
			,
			ExprI<R>
		{
			public Call(
				obj.op.TernaryI<P,P1,P2,R> op
				,
				obj.var.ExprI<P> arg
				,
				obj.var.ExprI<P1> arg1
				,
				obj.var.ExprI<P2> arg2
			)
				:base(op,arg,arg1,arg2)
			{

			}

		}
	}
}
