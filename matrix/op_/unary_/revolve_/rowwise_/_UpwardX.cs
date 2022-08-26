using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.revolve_.rowwise_
{
	static public class _UpwardX
	{
		static public void _Vod_assumeRowsPositive<T>(T[,] matrix)
		{
			var rowLastIndex = matrix.GetLength(0) - 1;

			var rowInitial = obj.matrix._RowsX.Row(matrix, 0).ToArray();

			for (int row = 0, rowInc =1; row < rowLastIndex; row++, rowInc++)
			{
				for (int c = 0; c < matrix.GetLength(1); c++)
				{
					matrix[row, c] = matrix[rowInc, c];
				}

			}
			for (int c = 0; c < matrix.GetLength(1); c++)
			{
				matrix[rowLastIndex,c] = rowInitial[c];
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
