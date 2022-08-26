using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_._binary_.args_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public abstract class SameTypeA<TArg>
		: nilnul.obj.call_._binary_.ArgArg1A1<TArg,TArg>

	{
		
		public SameTypeA(TArg arg,TArg arg1)
			:base(arg, arg1)
		{

		}
		
		
		
	}
}
