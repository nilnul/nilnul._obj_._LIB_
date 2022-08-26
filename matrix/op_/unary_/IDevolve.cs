using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_
{

	/// <summary>
	/// for rows or cols. if for rows,
	///		let c denote the count of rows
	///		for index,
	///			i -> (-i + a)% c
	///	if c is nil,
	///		for each index would iterate thru an empty collection, and this operation still holds tight.
	///		
	/// eg:
	///		for a matrix 3*7, that is 3 rows, 7 cols.
	///		take 5 as the offset  for the cols index.
	///		the col[x] will become col[  (-x +5  ) % 7]
	///			0 -> 5
	///			1->4
	///			...
	///			5 ->0
	///			6 -> 6
	/// 
	/// </summary>
	public interface IDevolve
	{
	}
}
