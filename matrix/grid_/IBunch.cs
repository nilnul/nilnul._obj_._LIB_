using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.grid_
{
	/// <summary>
	/// a grid in the form of one bunch. That is, only horizontal sperating lines.
	/// </summary>
	///
	[Obsolete(nameof(INonslice))]
	class IBunch
		:matrix.ISplit
		,
		IGrid
	{
	}
}
