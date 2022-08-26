using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_._binary_.opArgArg1_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public abstract class ArgSameTypeA<TOp,TArg>
		: nilnul.obj.call_._binary_.OpArgArg1A1<TOp,TArg,TArg>

	{
		
		public ArgSameTypeA(TOp op,TArg arg,TArg arg1)
			:base(op,arg, arg1)
		{

		}
		
		
		
	}
}
