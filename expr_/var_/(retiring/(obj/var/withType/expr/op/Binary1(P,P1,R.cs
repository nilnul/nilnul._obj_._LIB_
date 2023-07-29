using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr.op
{
	public partial class Binary1<P,P1,R>
		:BinaryI<P,P1,R>
	{
		private nilnul.obj.op.BinaryI<P,P1,R> _op;

		public nilnul.obj.op.BinaryI<P,P1,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Binary1(obj.op.BinaryI<P,P1,R> op )
		{
			this._op = op;
		}

		public virtual ExprI<R> eval(ExprI<P> arg,ExprI<P1> arg1)
		{
			return new obj.expr.op.binary.Call<P,P1,R>(op, arg,arg1);

			throw new NotImplementedException();
		}

		
	}
}
