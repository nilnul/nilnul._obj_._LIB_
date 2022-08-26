using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	[Obsolete()]

	public interface BeI2<out T,in TStr>
		:
		nilnul.obj.BeI1<TStr>

		where TStr:nilnul.obj.StrI2<T>
	{

	}

	[Obsolete()]
	public interface BeI2< T>
		:BeI2<T, nilnul.obj.StrI2< T>>
	{

	}



}
