using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.col.to_
{

	static public class _ToVecX
	{
		static public IEnumerable<T> _Seq_assumeCol<T>(T[,] matrix) {

			for (int i = 0; i < matrix.GetLength(0) ; i++)
			{
				yield return matrix[i, 0];
			}
		}

		static public T[] _Arr_assumeCol<T>(T[,] matrix) {

			return _Seq_assumeCol(matrix).ToArray();
		}

	}
}
