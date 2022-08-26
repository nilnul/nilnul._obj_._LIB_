using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.of_.vecs_
{
	/// <summary>
	/// note if rows are empty, the colcount is set 0.
	///  for empty rows,  to make the colcount nonnil, you should use other method.
	/// </summary>
	static public class _OfRowsX
	{
		static public T[,] _OfVecs_assumeSameArity<T>(IEnumerable<IEnumerable<T>> vecs) {
			if (vecs.Any())
			{
				var rowsCount = vecs.Count();
				var colsCount = vecs.First().Count();
				var r = new T[rowsCount, colsCount];

				for (int i = 0; i < rowsCount; i++)
				{
					for (int j = 0; j < colsCount; j++)
					{
						r[i, j] = vecs.ElementAt(i).ElementAt(j);
					}
				}
				return r;
			}
			return new T[0, 0];
		}
		static public T[,] OfVecs<T>(obj.str.strung.be_.sameArity.vow.Ee<T> vecs) {
			return _OfVecs_assumeSameArity(vecs.ee);
			
		}
		static public T[,] OfVecs<T>(IEnumerable<IEnumerable<T>> vecs) {
			return OfVecs(
				new obj.str.strung.be_.sameArity.vow.Ee<T>(vecs)
			);
		}
		static public T[,] OfParams<T>(params IEnumerable<T>[] vecs) {
			return OfVecs(
				(IEnumerable<IEnumerable<T>>)vecs
			);
		}


	}
}
