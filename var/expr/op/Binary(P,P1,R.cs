using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr.op
{
	public partial class Binary<P,P1,R>
		:BinaryI<P,P1,R>
	{
		private nilnul.obj.op.BinaryI<P,P1,R> _op;

		public nilnul.obj.op.BinaryI<P,P1,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Binary(obj.op.BinaryI<P,P1,R> op )
		{
			this._op = op;
		}

		public ExprI<R> eval(ExprI<P> arg,ExprI<P1> arg1)
		{
			return new Call(op, arg,arg1);

			throw new NotImplementedException();
		}

		public partial class Call
			:nilnul.obj.op.Call_OpArgArg1A<obj.op.BinaryI<P,P1,R>,obj.var.ExprI<P>, obj.var.ExprI<P1>>
			,
			ExprI<R>
		{
			public Call(
				obj.op.BinaryI<P,P1,R> op
				,
				obj.var.ExprI<P> arg
				,
				obj.var.ExprI<P1> arg1
			)
				:base(op,arg,arg1)
			{

			}

		}
	}
}
