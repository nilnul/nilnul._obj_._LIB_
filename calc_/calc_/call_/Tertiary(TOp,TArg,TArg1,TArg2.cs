using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public   class Tertiary<TOp,TArg,TArg1,TArg2>
		:nilnul.obj.call_._tertiary_.OpArgArg1Arg2A<TOp,TArg,TArg1,TArg2>
		where TOp:nilnul.obj.op_._tertiary_.BlankI
	{
		
		
		
		public Tertiary(TOp op,TArg arg,TArg1 arg1,TArg2 arg2)
			:base(op,arg,arg1,arg2)
		{ 
			
		}

		
	}



	
}
