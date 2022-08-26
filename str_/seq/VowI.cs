using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	public interface VowI<T,TStr>
		:nilnul.obj.VowI2<TStr>
		where TStr:nilnul.obj.StrI2<T>

	{
	}

	public interface VowI<T>:VowI<T, obj.str_.SeqI2<T> > { }
}
