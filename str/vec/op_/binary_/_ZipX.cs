using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.str.vec.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		memberwise concat
	///		zip
	static public class _ZipX
	{
		
		static public IEnumerable<IEnumerable< T>> _SeqOfSeq_assumesVecOfStr<T>(
			IEnumerator<IEnumerable< T >> a
			,
			IEnumerator<IEnumerable<T>> b
		)
		{
			while (a.MoveNext())
			{
				b.MoveNext();
				yield return a.Current.Concat(b.Current);

			}
		}

		static public IEnumerable<IEnumerable< T>> _SeqOfSeq_byEnumerator_assumesVecOfStr<T>(
			IEnumerable<IEnumerable< T >> a
			,
			IEnumerable<IEnumerable<T>> b
		)
		{
			return _SeqOfSeq_assumesVecOfStr(a.GetEnumerator(),b.GetEnumerator());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable< T>> _SeqOfSeq_assumesVecOfStr<T>(
			IEnumerable<IEnumerable< T >> a
			,
			IEnumerable<IEnumerable<T>> b
		)
		{
			return a.Zip(	//would return when reaching the end of either vec, but we have assumed that the two pars are of the same length;
				b, 
				(e,i)=> e.Concat(i )
			);
		}





	}
}
