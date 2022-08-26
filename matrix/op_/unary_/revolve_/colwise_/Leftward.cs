using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.revolve_.colwise_
{
	static public class _LeftwardX
	{
		static public void _Vod_assumeColsPositive<T>(T[,] matrix)
		{
			var colLastIndex = matrix.GetLength(1) - 1;

			var colInitial = obj.matrix._ExtensionsX.Col(matrix, 0).ToArray();

			for (int col = 0; col < colLastIndex; col++)
			{
				for (int r = 0; r < matrix.GetLength(0); r++)
				{
					matrix[r, col] = matrix[r, col + 1];
				}

			}
			for (int r = 0; r < matrix.GetLength(0); r++)
			{
				matrix[r, colLastIndex] = colInitial[r];
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
		static public void _Vod_assumeColsPositive_timesNonneg<T>(T[,] matrix,int times)
		{
			for (int i = 0; i < times; i++)
			{
				_Vod_assumeColsPositive(matrix);
			}
		}


	}
}
