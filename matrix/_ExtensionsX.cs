using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	/// <summary>
	/// slice the matrix (as a line) into same-lengthed segment, each segment is called a row
	/// </summary>
	static public class _ExtensionsX
	{
		static public IEnumerable<IEnumerable<T>> Cols<T>(this T[,] matrix) {
			return Enumerable.Range(0, matrix.GetLength(1))
			   .Select(x => matrix.Col(x))
			  ;
		}

		/// <summary>
		/// assume cols count to be positive
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <param name="columnNumber"></param>
		/// <returns></returns>
		static public IEnumerable<T> Col<T>(this T[,] matrix, int columnNumber)
		{
			return Enumerable.Range(0, matrix.GetLength(0))
					.Select(x => matrix[x, columnNumber])
					;
		}


		
	}
}
