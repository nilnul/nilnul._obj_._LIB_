using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.row.to_
{

	static public class _ToVecX
	{
		static public IEnumerable<T> _Seq_assumeRow<T>(T[,] matrix) {

			for (int i = 0; i < matrix.GetLength(1) ; i++)
			{
				yield return matrix[0,i];
			}
		}

		static public T[] _Arr_assumeRow<T>(T[,] matrix) {

			return _Seq_assumeRow(matrix).ToArray();
		}

	}
}
