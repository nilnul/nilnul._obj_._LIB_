using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	/// 
	/// <summary>
	/// slice the matrix (as a line) into same-lengthed segment, each segment is called a row
	/// </summary>
	static public class _RowsX
	{
		static public IEnumerable<IEnumerable<T>> Rows<T>(this T[,] matrix) {
			return Enumerable.Range(0, matrix.GetLength(0))
			   .Select(x => matrix.Row(x))
			  ;
		}

	

		static public IEnumerable< T> Row<T>(this T[,] matrix, int rowNumber)
		{
			return Enumerable.Range(0, matrix.GetLength(1))
					.Select(x => matrix[rowNumber, x])
					;
		}
	}
}
