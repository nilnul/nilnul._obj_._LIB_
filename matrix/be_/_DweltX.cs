using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_
{
	/// <summary>
	/// at least one cel.
	/// excluding:
	///		0*0
	///		1*0
	///		3*0
	/// </summary>
	static public class _DweltX
	{
		static public bool IsDwelt<T>(this T[,] m) {
			return!_EmptyX.IsEmpty(m);
		}
	}
}
