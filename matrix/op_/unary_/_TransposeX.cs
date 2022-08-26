using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_
{
	static public class _TransposeX
	{
		static public T[,] Transpose<T>(this T[,] matrix)
		{
			var rows = matrix.GetLength(1);
			int cols = matrix.GetLength(0);
			T[,] r = new T[rows, cols];

			for (int i = 0; i < rows;i++ )
			{
				for (int j = 0; j <cols; j++) {
					r[i, j] = matrix[j, i];
				}
			}
			return r;

		}



	}
}
