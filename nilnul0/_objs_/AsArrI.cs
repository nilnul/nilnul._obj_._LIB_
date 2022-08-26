using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._objs_
{
	/// <summary>
	///  any finite slew (set, array, list, matrix, multi-dimensional array) of objects must be convertible to Str. This is theoretically significant.
	/// </summary>
	public interface AsArrI<T>
	{
		T[] asArr();
	}
}
