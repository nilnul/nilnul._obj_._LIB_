using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_
{

	/// <summary>
	/// for each index,
	///		the new index is the old index plus a number, and congruently modulo the length to get a number in the interval [0, length); by modulo subtraction, mapping integer to [0,l), where l is the length.
	/// 
	/// eg:
	///		for a matrix 3*7, that is 3 rows, 7 cols.
	///		take -5 as the offset  for the cols index.
	///		the col[x] will become col[  (x -5  ) % 7]
	///			0 -> 2
	///			1 -> 3
	///			...
	///			4 -> 6
	///			5 -> 0
	///			6 -> 1
	///			
	///
	/// if the length is nil, then there is no indexes to operate on. So this operation still holds tight.
	/// 
	/// </summary>
	/// alias:
	///		revolve
	///		modulo
	///		mod
	///		congru
	///		congruent
	///		remainder
	public interface IRevolve
	{
	}
}
