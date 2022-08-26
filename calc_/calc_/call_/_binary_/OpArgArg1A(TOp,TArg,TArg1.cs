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
	public abstract class OpArgArg1A1<TOp,TArg,TArg1>
		: nilnul.obj.call_._unary_.OpArgA1<TOp,TArg>

	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public OpArgArg1A1(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg)
		{
			this._arg1 = arg1;

		}
		
		
		
	}
}
