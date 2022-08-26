using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_._tertiary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public abstract  class OpArgArg1Arg2A<TOp,TArg,TArg1,TArg2>
		: nilnul.obj.call_._binary_.OpArgArg1A<TOp,TArg,TArg1>
		where TOp:nilnul.obj._op_.BlankI

	{
		private TArg2 _arg2;

		public TArg2 arg2
		{
			get { return _arg2; }
			set { _arg2 = value; }
		}
		public OpArgArg1Arg2A(TOp op,TArg arg,TArg1 arg1,TArg2 arg2)
			:base(op,arg,arg1)
		{
			this.arg2 = arg2;

		}
		
		
		
	}
}
