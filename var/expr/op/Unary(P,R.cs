using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial class Unary<P,R>
		:UnaryI<P,R>
	{
		private nilnul.obj.op.UnaryI<P,R> _op;

		public nilnul.obj.op.UnaryI<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}
		

		public Unary(obj.op.UnaryI<P,R> op )
		{
			this._op = op;


		}

		public ExprI<R> eval(ExprI<P> arg)
		{
			return new Call(op, arg);

			throw new NotImplementedException();
		}

		public partial class Call
			:nilnul.obj.op.Call_OpArgA<obj.op.UnaryI<P,R>,obj.var.ExprI<P>>
			,
			ExprI<R>
		{
			public Call(
				obj.op.UnaryI<P,R> op
				,
				obj.var.ExprI<P> arg
			)
				:base(op,arg)
			{

			}

		}
	}
}
