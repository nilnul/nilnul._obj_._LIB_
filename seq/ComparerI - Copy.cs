using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	

	public interface ComparerOfEnumerableI<TElement>
		:IComparer<IEnumerable<TElement>>
	{ }
}
