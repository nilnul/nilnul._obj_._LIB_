using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.grid_
{
	/// <summary>
	/// a grid in the form of one belt. That is, only vertical bunches.
	/// </summary>
	///
	[Obsolete(nameof(INonsplit))]
	public interface ISlice
		:
		matrix.ISlice
		,
		IGrid
	{
	}
}
