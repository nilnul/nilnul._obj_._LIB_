using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.of_.vecs_
{
	 public class OfCols<T>
	{
		public T[,] _ofCols_assumeRect(IEnumerable<IEnumerable<T>> vecs) {
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
		 public T[,] ofCols(obj.str.strung.be_.sameArity.vow.Ee<T> vecs) {
			return _ofCols_assumeRect(vecs.ee);
			
		}
		 public T[,] ofCols(IEnumerable<IEnumerable<T>> vecs) {
			return ofCols(
				new obj.str.strung.be_.sameArity.vow.Ee<T>(vecs)
			);
		}
		 public T[,] ofColsByParams(params IEnumerable<T>[] vecs)
		{
			return ofCols(
				(IEnumerable<IEnumerable<T>>)vecs
			);
		}


		static public OfCols<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfCols<T>>.Instance;
			}
		}

	}
}
