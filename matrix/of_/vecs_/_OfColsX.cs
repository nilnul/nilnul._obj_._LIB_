using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.of_.vecs_
{
	static public class _OfColsX
	{
		static public T[,] _OfVecs_assumeSameArity<T>(IEnumerable<IEnumerable<T>> vecs) {
			if (vecs.Any())
			{
				var cols1Count = vecs.Count();
				var rowsCount = vecs.First().Count();
				var r = new T[ rowsCount, cols1Count];

				for (int i = 0; i < cols1Count; i++)
				{
					for (int j = 0; j < rowsCount; j++)
					{
						r[ j,i] = vecs.ElementAt(i).ElementAt(j);
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
		static public T[,] OfParams<T>(params IEnumerable<T>[] vecs)
		{
			return OfVecs(
				(IEnumerable<IEnumerable<T>>)vecs
			);
		}
	}
}
