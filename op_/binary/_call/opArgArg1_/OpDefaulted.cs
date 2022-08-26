using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.op_.binary._call.opArgArg1_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// <remarks>
	/// becuz Tuple is in an earlier layer than Op, this is named ArgOp, not OpArg;
	///			this is also convenient for reify Arg1ArgOp as we better inherit Arg1Arg, not Op as previous has more stake to be inherited.
	///			this is also convenet if we wang to write more classes that are with more args. we can simply copy and rename the existant classes with the more args, and just change the parent class, and the contructor. The "op" aspect needs no change.
	/// </remarks>
	/// 

	public abstract  class OpDefaultA <TOp,TArg, TArg1>
		:
		OpArgArg1A<TOp, TArg, TArg1>

		where TOp:new()
	{
		
		
		
		public OpDefaultA(TOp op,TArg arg,TArg1 arg1 )
			:base(nilnul.obj_.Singleton<TOp>.Instance,arg, arg1 )
		{

			
		}
	}

	public abstract class OpDefaultA<TOp, TArg> : OpDefaultA<TOp, TArg, TArg>
		where TOp:new()
	{
		public OpDefaultA(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
	}
}
