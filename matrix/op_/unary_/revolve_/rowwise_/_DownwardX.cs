using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.revolve_.rowwise_
{
	static public class _DownwardX
	{
		static public void _Vod_assumeRowsPositive<T>(T[,] matrix)
		{
			var rowLastIndex = matrix.GetLength(0) - 1;

			var rowLast = obj.matrix._RowsX.Row(matrix, rowLastIndex).ToArray();


			for (int row1 = rowLastIndex, rowDec=rowLastIndex-1; row1 >0; row1--, rowDec--)
			{
				for (int c = 0; c < matrix.GetLength(1); c++)
				{
					matrix[ row1,c] = matrix[ rowDec,c];
				}

			}

			for (int c = 0; c < matrix.GetLength(1); c++)
			{
				matrix[0, c] = rowLast[c];
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <param name="times"></param>
		/// <remarks>
		/// algorithm:
		///		*) call the rotate by one ntimes.
		/// </remarks>
		static public void _Vod_assumeRowsPositive_timesNonneg<T>(T[,] matrix,int times)
		{
			for (int i = 0; i < times; i++)
			{
				_Vod_assumeRowsPositive(matrix);
			}
		}


	}
}
