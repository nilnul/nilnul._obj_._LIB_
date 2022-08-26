using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
{
	public partial class Nullary<TR>
		:nilnul.obj.op.NullaryI<ExprI2<TR>>
	{
		private nilnul.obj.op.Nullary1<ExprI2< TR>> _op;

		public nilnul.obj.op.Nullary1<ExprI2< TR>> op
		{
			get { return _op; }
			set { _op = value; }
		}
		

			
		public Nullary(nilnul.obj.op.Nullary1<ExprI2< TR>> op)
		{
			this.op = op;

		}





		public ExprI2<TR> eval()
		{
			return op.eval();
			throw new NotImplementedException();
		}


	}
}
