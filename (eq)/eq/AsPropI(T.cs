using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.eq
{
	public partial interface AsPropI<T>
	{
		IEqualityComparer<T> eq { get; }

	}
}
