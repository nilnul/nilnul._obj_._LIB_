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
	//[Obsolete(nameof(nilnul.obj.call_._binary_.OpArgArg1A<TOp,TArg,TArg1>))]
	public abstract  class OpArgArg1A<TOp,TArg,TArg1>
		:OpArgA<TOp,TArg>
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
	public abstract class OpArgArg1A<TOp, TArg>
		: OpArgArg1A<TOp, TArg, TArg>
	{
		protected OpArgArg1A(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
	}

}
