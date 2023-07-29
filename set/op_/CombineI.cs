using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{

	[Obsolete("deferred to nilnul.set")]
	public interface CombineI<T>
		:nilnul.obj.CombineI<HashSet<T>>
	{
	}
}
