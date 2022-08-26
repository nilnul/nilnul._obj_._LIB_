using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// combine two objects (might be of different type) into one
	/// </summary>
	public interface CombineI
	{
	}

	[Obsolete()]
	public interface CombineI<in T, in T1, out TR> : CombineI
	
	{
		TR eval(T arg, T1 arg1);
	}

	[Obsolete()]
	public interface CombineI<in T, out TR> : CombineI<T, T, TR> { }

	[Obsolete()]
	public interface CombineI<T> : CombineI<T, T> { }
}
