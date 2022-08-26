using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.vec_
{
	static public class _QuadX
	{
		static public (T, T,T,T) _ValTup_assumeQuad<T>(this IEnumerator<T> seq) {
			seq.MoveNext();
			var t = seq.Current;
			seq.MoveNext();
			var t1 = seq.Current;
			seq.MoveNext();
			var t2 = seq.Current;
			seq.MoveNext();
			return (t,t1,t2, seq.Current);
		}
		static public (T, T,T,T) _ValTup_assumeQuad<T>(this IEnumerable<T> seq) {
			return _ValTup_assumeQuad(seq.GetEnumerator());
		}


	}
}
