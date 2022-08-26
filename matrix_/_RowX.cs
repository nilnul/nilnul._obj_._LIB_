using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_
{

	static public class _RowX
	{
		static public T[,] Matrix<T>(IEnumerable<T> str) {
			var c = str.Count();
			var r = new T[1, c];

			for (int i = 0; i < c; i++)
			{
				r[1, i] = str.ElementAt(i);

			}
			return r;
		}
		static public T[,] Matrix<T>(params T[] str) {
			return Matrix(
				(IEnumerable<T>)str
			);
		}

	}
}
