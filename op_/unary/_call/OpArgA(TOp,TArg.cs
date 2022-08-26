using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.op_.unary._call
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

	public abstract  class OpArgA< TOp, TArg>
		:op._call_.OpA<TOp>
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}
		
		
		public OpArgA( TOp op, TArg arg)
			:base(op)
		{
			this.arg = arg;
			
		}
	}
}
