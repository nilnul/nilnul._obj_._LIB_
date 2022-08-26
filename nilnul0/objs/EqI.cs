using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	public interface EqI<TItem> :
		IEqualityComparer<IEnumerable<TItem>>
	{
		

	}

}
