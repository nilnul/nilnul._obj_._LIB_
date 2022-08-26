using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._combine_
{
	/// <summary>
	/// for "combine" that has a "unit"
	/// </summary>
	public interface UnitI<T>
	{
		T unit { get; }
	}
}
