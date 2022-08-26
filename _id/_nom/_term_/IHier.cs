using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom._term_
{
	/// <summary>
	/// how many levels of grouping. This helps determine how many "_"s are needed when phrasing.
	/// <see cref="term_.IIdiom"/>'s hier is 0
	/// <see cref="term_.terms"/>'s hier is the biggest child hier +1
	/// eg:
	///		abc  , 0
	///			when uppered: ABC
	///		abcDef, 1
	///			when uppered: ABC_DEF
	///		abcDef_hij, 2
	///			when uppered: ABC_DEF__HIJ
	/// </summary>
	public interface IHier
	{
		int hier { get; }
	}
}
