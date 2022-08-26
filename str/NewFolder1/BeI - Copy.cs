using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{

	[Obsolete()]
	public interface BeI1< T>
		:nilnul.obj.BeI1<nilnul.obj.StrI1<T>>
	{

	}

	[Obsolete()]
	public interface BeI1<T,in TStr>
		:nilnul.obj.BeI1<TStr>

		where TStr:nilnul.obj.StrI1<T>
	{

	}





}
