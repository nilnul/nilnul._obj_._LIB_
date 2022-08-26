using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj._call_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract  class OpArg<TOp, TArg> : OpA2<TOp>

	{
		public OpArg(TOp op, TArg arg):base(op)
		{
			_arg = arg;
		}

		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


	}
}
