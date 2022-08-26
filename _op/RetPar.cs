using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._op
{
	public interface RetParI<out R, in P>:_retPar.ParI<P>, _retPar.RetI<R>
	{
	}

	
}
