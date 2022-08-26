using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.bit
{
	public partial interface PredicateI<T>:PredicateI
	{
		bool is_(T obj);
	}
}
