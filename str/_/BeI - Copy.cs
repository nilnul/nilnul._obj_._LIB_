using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	[Obsolete()]
	public interface BeI<T>
		:nilnul.obj.BeI<IEnumerable<T>>
	{
	}
}
