using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.op
{
	public interface ListOpI<TArg, TResult> 
		: ListOpI_P<TArg>
		, ListOpI_R<TResult>
	{

		
	}
}
