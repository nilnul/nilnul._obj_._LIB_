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

	public abstract  class ArgOpA<TArg, TOp>
		:ArgA<TArg>
	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}
		
		
		public ArgOpA(TArg arg, TOp op)
			:base(arg)
		{
			this.op = op;
			
		}
	}
}
