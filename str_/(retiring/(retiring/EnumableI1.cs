using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete()]
	public interface EnumableI1<T>:IEnumerable<T>,nilnul.obj.StrI<T>
		,nilnul.obj.StrI1<T>
	{
	}

	
}
