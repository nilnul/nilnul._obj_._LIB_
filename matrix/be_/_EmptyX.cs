using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_
{
	/// <summary>
	/// eg:
	///		0*0
	///		1*0
	///		3*0
	/// </summary>
	static public class _EmptyX
	{
		static public bool IsEmpty<T>(this T[,] m) {
			return m.GetLength(0) == 0 || m.GetLength(1) == 0;
		}
	}
}
