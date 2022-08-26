using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_._binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public abstract class OpArgArg1A<TOp,TArg,TArg1>
		: nilnul.obj.call_._unary_.OpArgA<TOp,TArg>
		where TOp:nilnul.obj._op_.BlankI //to use in tertiary

	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public OpArgArg1A(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg)
		{
			this.arg1 = arg1;

		}
		
		
		
	}
}
