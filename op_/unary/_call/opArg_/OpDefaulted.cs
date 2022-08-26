using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.op_.unary._call.opArg_
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

	public abstract  class OpDefault <TOp,TArg>
		:
		OpArgA<TOp, TArg>

		where TOp:new()
	{
		
		
		
		public OpDefault(TOp op,TArg arg )
			:base(nilnul.obj_.Singleton<TOp>.Instance,arg )
		{

			
		}
	}
}
