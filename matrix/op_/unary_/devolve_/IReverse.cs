using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.devolve_
{

	/// <summary>
	/// 
	/// eg:
	///		for a matrix 3*7, that is 3 rows, 7 cols.
	///		 for the cols index
	///		take 7-1 as the offset 
	///			the col[x] will become col[  (-x +6  ) % 7]
	///				0 ->6
	///				1 -> 5
	///				...
	///				5 -> 1
	///				6-> 0
	/// 
	/// </summary>
	public interface IReverse
	{
	}
}
