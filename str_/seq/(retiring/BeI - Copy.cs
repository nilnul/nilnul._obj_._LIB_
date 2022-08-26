using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	[Obsolete()]
	public interface BeI<T>
		:nilnul.obj.BeI1<nilnul.obj.str_.EnumableI2<T>>
	{

	}

	[Obsolete()]
	public interface BeI<T,TStr>
		:nilnul.obj.BeI1<TStr>
		where TStr:nilnul.obj.str_.EnumableI2<T>
	{

	}



}
