using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public interface VowI2<T,TStr>
		:nilnul.obj.VowI2<TStr>
		where TStr:IEnumerable<T>

	{
	}
	public interface VowI2<T>
		:VowI2<T,IEnumerable<T>>
		

	{
	}

}
