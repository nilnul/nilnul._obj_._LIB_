using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.cel
{
	/// <summary>
	/// cyclic child. the next row/col is the first; then move to the end, then move to the beginning, then stop before the specified row/col.
	/// </summary>
	/// alias:
	///		child
	///			cyclic
	static public class _ChildX
	{
		static public T[,] _Child_celAssumeValid<T>(in T[,] matrix, in int row, in int col)
		{

			var rows = matrix.GetLength(0);
			var cols = matrix.GetLength(1);
			var rowsDec = rows - 1;
			var colsDec = cols - 1;

			var r = new T[
			   rowsDec
			   ,
			   colsDec
		   ];

			var rowInc = row + 1;
			var colInc = col + 1;

			for (int i = 0; i < rowsDec; i++)
			{
				for (int j = 0; j <colsDec; j++)
				{

					r[i, j] = matrix[
						(rowInc+i)% rows
						,
						(colInc+j) % cols
					];
				}
			}
			return r;
		}
	}
}