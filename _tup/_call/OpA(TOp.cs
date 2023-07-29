using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._tuple._call
{
	public abstract class OpA<TOp>
	{

		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		public OpA(TOp op)
		{
			_op = op;

		}


	}
}
