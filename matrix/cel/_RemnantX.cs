using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.cel
{
	/// <summary>
	/// remove the row as well as the col. the original matrix's orientation is not changed in contrast with <see cref="_ChildX"/>, which translates all rows/cols before the cel to the very end.
	/// </summary>
	/// alias:
	///		remnant:
	///			removed
	static public class _RemnantX
	{
		static public  T[,] _Remnant_celAssumeValid<T>(in T[,] matrix, in int row2del, in int col2del) {

			var rows = matrix.GetLength(0);
			var cols = matrix.GetLength(1);
			var rowsDec = rows - 1;
			var colsDec = cols - 1;

			var r = new T[
			   rowsDec
			   ,
			   colsDec
		   ];

			//var row2delInc = row2del + 1;
			//var col2delInc = col2del + 1;

		
			int i = 0;
			int j;

			for (; i < row2del; i++)
			{
				 j = 0;
				for (; j < col2del; j++)
				{

					r[i, j] = matrix[i,j];
				}
				//j++;
				for (int colInOld = j+1; j < colsDec; j=colInOld, colInOld++)
				{
					r[i, j] = matrix[i, colInOld];
				}

			}

			//i++;

			for (var rowInOld= i+1; i < rowsDec; i=rowInOld, rowInOld++)
			{

				 j = 0;
				for (; j < col2del; j++)
				{
					r[i, j] = matrix[rowInOld,j];
				}
				//j++;
				for (var colInOld = j+1 ; j < colsDec; j=colInOld, colInOld++)
				{
					r[i, j] = matrix[rowInOld, colInOld];
				}

			}

			return  r;

		}
	}
}
