using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.revolve_
{

	/// <summary>
	///
	///  if the offset is negtive
	/// eg:
	///		for a matrix 3*7, that is 3 rows, 7 cols.
	///		take -5 as the offset  for the cols index.
	///		the col[x] will become col[  (x -5  ) % 7]
	///			0 -> 2
	///			1 -> 3
	///			...
	///			5 -> 0
	///			6 -> 1
	/// 
	/// </summary>
	public interface ILeftward:IRevolve
	{
	}
}
