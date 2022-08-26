using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._op
{
	[Obsolete(nameof(RetParI<R,P>))]
	public interface GenericI<in P,out R>
	{
		R op(P arg);
	}

	
}
