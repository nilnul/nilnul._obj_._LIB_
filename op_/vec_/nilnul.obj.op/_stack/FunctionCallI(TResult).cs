using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
    public partial interface FunctionCallI<TResult> : ExprI<TResult>
        
        
	{
           

		IFunction<TResult> function
		{
			get;
		}

	}
}
