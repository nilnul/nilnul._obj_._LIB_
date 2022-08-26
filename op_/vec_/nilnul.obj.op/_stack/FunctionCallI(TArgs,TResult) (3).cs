using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{

	/// <summary>
	/// given the function.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface FunctionCallI<TArg, TResult> 
        :
        
        FunctionCallI<TResult>
		
	{
		FunctionI<TArg, TResult> function
		{
			get;
		}

		TArg x
		{
			get;
			set;
		}


	}
}