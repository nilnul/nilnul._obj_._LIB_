using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo
{
	[Obsolete()]
	public interface BeI<T>:BeI<T,T>
	{
	}

	[Obsolete()]
	public interface BeI<T,T1>
	{
		bool be(T a, T1 b);
	}


}
