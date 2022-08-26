using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.op_.binary._call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// <remarks>
	/// becuz Tuple is in an earlier layer than Op, this is named ArgOp, not OpArg;
	///			this is also convenient for reify Arg1ArgOp as we better inherit Arg1Arg, not Op as previous has more stake to be inherited.
	/// </remarks>
	/// 

	public abstract  class OpArgArg1A< TOp, TArg,TArg1>
		:op_.unary._call.OpArgA<TOp,TArg>
	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		
		
		public OpArgArg1A( TOp op, TArg arg,TArg1 arg1)
			:base(op,arg)
		{
			this.arg1 = arg1;
			
		}
	}
	public abstract class OpArgArg1A<TOp, TArg> : OpArgArg1A<TOp, TArg, TArg>
	{
		protected OpArgArg1A(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
	}
}
