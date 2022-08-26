using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	[Obsolete()]
	public interface BeI<T,TStr>
		:nilnul.obj.BeI<TStr>
		where TStr:nilnul.obj.StrI<T>
	{

	}


}
