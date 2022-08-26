using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.no
{
	public class Call1<T, TOp>

		where TOp: nilnul.obj.no.OpI<T>
	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Call1(TOp op)
		{
			_op = op;
		}


		public T eval() {
			return op.eval();
		}

		public override string ToString()
		{
			return _op.ToString();
		}
	}
}
