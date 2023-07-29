using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
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
			return new unary.Call<P,R>(op, arg);

			throw new NotImplementedException();
		}

	}
}
