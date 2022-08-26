using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.no
{
	[Obsolete()]
	public class Call<T>
	{
		private Op<T> _op;

		public Op<T> op
		{
			get { return _op; }
			set { _op = value; }
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
