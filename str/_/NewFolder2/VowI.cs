using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	[Obsolete()]
	public interface VowI1<T,TStr>
		:nilnul.obj.VowI2<TStr>
		where TStr:nilnul.obj.StrI2<T>

	{
	}
	[Obsolete()]
	public interface VowI1<T>
		:VowI1<T,nilnul.obj.StrI2<T>>
		

	{
	}

}
