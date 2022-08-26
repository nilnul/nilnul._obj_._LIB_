using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._op
{
	[Obsolete()]
	public interface EvalI<in P,out R>
	{
		R eval(P arg);
	}

	[Obsolete()]
	public interface EvalI<T> : EvalI<T, T> {

	}
}
