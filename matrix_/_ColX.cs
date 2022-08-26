using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_
{

	static public class _ColX
	{
		static public T[,] Matrix<T>(IEnumerable<T> str) {
			var c = str.Count();
			var r = new T[ c,1];

			for (int i = 0; i < c; i++)
			{
				r[ i,1] = str.ElementAt(i);

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
