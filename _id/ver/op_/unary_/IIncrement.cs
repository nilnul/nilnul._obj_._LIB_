using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id.ver.op_.unary_
{
	/// <summary>
	/// increase the version by 1.
	/// eg:
	/// "" -> 1
	/// 1 -> 2
	/// 9 -> 10
	/// </summary>
	/// when 0 is prefixed, we can:
	///		either increment the last "0"
	///			"0" ->1
	///			"000" -> "001"
	///		or append 1
	///			"0" -> "01"
	///			000 -> 0001
	/// 
	class IIncrement:IIncrease
	{
	}
}
