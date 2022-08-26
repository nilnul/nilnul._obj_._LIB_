using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ.ns_.xpN_
{
	/// <summary>
	/// eg:
	///		nilnul1.abc.def.abc1
	///			where the term for the seg: abc, and "abc1" are repeated.
	///	this shall be avoided, as "abc.C" might be ambiguous and longer prefixing ns is required.
	///	When we need to repeat a seg in terms, consider go back to where the first occurs, and use a new name.
	///		eg:
	///			nilnul.num.real.vec.Vec is named as nilnul.num.real.Matrix.
	/// </summary>
	class SegsNondistinctByTerm
	{
	}
}
