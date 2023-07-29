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
	/// 
	[Obsolete()]
	public abstract  class OpA<TOp> : OpI<TOp>
		//where TOp:nilnul.obj._op_.BlankI

	{
		private TOp _op;
		public TOp op
		{
			get
			{
				return _op;
			}
			set
			{
				_op=value;
			}
		}
		public OpA(TOp op_)
		{
			this.op = op_;
		}
	}
}
