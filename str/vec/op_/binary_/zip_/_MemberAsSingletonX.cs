using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.str.vec.op_.binary_.zip_
{
	static public class _MemberAsSingletonX
	{
		static public IEnumerable<(T,T1)> _SeqOfCo_assumesVec<T,T1>(
			IEnumerator<T> a
			,
			IEnumerator<T1> b
		)
		{
			while (a.MoveNext())
			{
				b.MoveNext();
				yield return (a.Current, b.Current);

			}
		}

		static public IEnumerable<(T,T)> _SeqOfCo_assumesVec_ovHomo<T>(
			IEnumerator<T> a
			,
			IEnumerator<T> b
		)
		{
			return _SeqOfCo_assumesVec<T, T>(a, b);
		}
		static public IEnumerable<(T,T1)> _SeqOfCo_assumesVec<T,T1>(
	IEnumerable<T> a
	,
	IEnumerable<T1> b
)
		{
			return _SeqOfCo_assumesVec(
				a.GetEnumerator(), b.GetEnumerator()
			);
		}

		static public IEnumerable<(T,T)> _SeqOfCo_assumesVec_ovHomo<T>(
	IEnumerable<T> a
	,
	IEnumerable<T> b
)
		{
			return _SeqOfCo_assumesVec_ovHomo<T>(
				a.GetEnumerator(), b.GetEnumerator()
			);
		}


		static public IEnumerable<( T,T)> _SeqOfCo_bySel_assumesVec<T>(
			IEnumerable< T> a
			,
			IEnumerable<T> b
		)
		{
			return a.Select(
				(e,i)=> (e, b.ElementAt(i) )
			);
		}






	}
}
