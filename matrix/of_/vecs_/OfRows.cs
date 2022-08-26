using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.of_.vecs_
{
	public class OfRows<T>
	{
		/// <summary>
		/// matrix is prefered over Seq{Seq{T}} in that matrix contains compart's arity even if it's empty
		/// </summary>
		/// <param name="vecs"></param>
		/// <returns></returns>
		 public T[,] _ofRows_assumeSameArity(IEnumerable<IEnumerable<T>> vecs) {
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
		 public T[,] ofRows(obj.str.strung.be_.sameArity.vow.Ee<T> vecs) {
			return _ofRows_assumeSameArity(vecs.ee);
			
		}
		 public T[,] ofRows(IEnumerable<IEnumerable<T>> vecs) {
			return ofRows(
				new obj.str.strung.be_.sameArity.vow.Ee<T>(vecs)
			);
		}
		 public T[,] ofRowsByParams(params IEnumerable<T>[] vecs) {
			return ofRows(
				(IEnumerable<IEnumerable<T>>)vecs
			);
		}

		static public OfRows<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfRows<T>>.Instance;
			}
		}



	}
}
