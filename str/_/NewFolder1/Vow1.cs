using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	[Obsolete()]
	public interface VowI1<T,TStr>
		:
		nilnul.obj.VowI2<TStr>
		where TStr:nilnul.ObjsI3<T>
	{
	}

	[Obsolete()]
	public interface VowI1<T> : nilnul.obj.VowI2<nilnul.ObjsI3<T>>
	{
	}

}
