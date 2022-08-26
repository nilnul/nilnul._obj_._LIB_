using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	

	public interface CombineI1<in T, in T1, out TR> : CombineI
	
	{
		TR combine(T arg, T1 arg1);
	}

	public interface CombineI1<in T, out TR> : CombineI1<T, T, TR> { }

	public interface CombineI1<T> : CombineI1<T, T> { }
}
