using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{
	[Obsolete()]
	public interface UnaryI<T>:
		
		IUnary<T>
		,
		op_.UnaryI<T>

	{
	}
}
