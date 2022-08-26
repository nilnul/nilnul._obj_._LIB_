using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._str_
{
	/// <summary>
	/// finite ordered objects
	/// </summary>
	public interface _BlankI {

	}
	/// <summary>
	///  any finite slew (set, array, list, matrix, multi-dimensional array) of objects must be convertible to Str. This is theoretically significant.
	/// </summary>
	public interface BlankI<out T>:_BlankI
	{
		
	}
}
