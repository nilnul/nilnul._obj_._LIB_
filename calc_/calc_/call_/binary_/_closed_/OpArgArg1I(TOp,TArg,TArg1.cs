using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_.binary_._closed_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public interface ArgsI<TArg>
		: nilnul.obj.call_._binary_.._unary_.OpArgI<TOp,TArg>
		,
		
		ArgsI<TArg1>

	{
		
		
		
		
	}
}
