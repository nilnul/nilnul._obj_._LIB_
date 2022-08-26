using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	[Obsolete(nameof(nilnul.obj.str.IAccumulate))]
	public interface AccumulateI<T>
	{
		T accumulate(IEnumerable<T> objs);
	}
}
