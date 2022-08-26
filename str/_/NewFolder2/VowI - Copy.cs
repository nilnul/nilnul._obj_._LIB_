using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	[Obsolete()]
	public interface VowI<T,TStr>
		:nilnul.obj.VowI<TStr>
		where TStr:nilnul.obj.StrI1<T>

	{
	}
}
