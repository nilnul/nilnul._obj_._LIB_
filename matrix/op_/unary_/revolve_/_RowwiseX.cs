using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.revolve_
{
	static public class _RowwiseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <param name="times"></param>
		/// <remarks>
		/// </remarks>
		static public void _Vod_assumeColsPositive<T>(T[,] matrix,int times)
		{
			if (times<0)
			{
				rowwise_._UpwardX._Vod_assumeRowsPositive_timesNonneg(matrix, -times);
				return;
			}
			if (times>0)
			{
				rowwise_._DownwardX._Vod_assumeRowsPositive_timesNonneg(matrix,times);

			}

		}


	}
}
