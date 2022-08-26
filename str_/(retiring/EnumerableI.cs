using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	[Obsolete()]
	public interface EnumerableI<T>
		:nilnul.ObjsI2<T>
		,
		IEnumerable<T>
	{
	}
}
