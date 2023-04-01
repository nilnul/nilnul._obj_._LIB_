using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.str.strung.op_.binary_
{
	static public class _CartesianX
	{
		/// <summary>
		/// using the method syntax
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <param name="a"> the element shall be regarded as 1-vec</param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public IEnumerable<(T, T1)> Seq<T, T1>(
			IEnumerable<T> a
			,
			IEnumerable<T1> b
		)
		{
			return a.SelectMany(
				x => b.Select(
					y => (x, y)
				)
			);
		}

		static public IEnumerable<(T, T1)> Seq_byQuery<T, T1>(
			IEnumerable<T> a
			,
			IEnumerable<T1> b
		)
		{
			return from x in a
				   from y in b
				   select (x, y);
		}


		static public IEnumerable<IEnumerable<T>> Sequence_byQuery<T>(
			IEnumerable<T> a
			,
			IEnumerable<T> b
		)
		{
			return from x in a
				   from y in b
				   select new[] { x, y };
		}



	}
}
