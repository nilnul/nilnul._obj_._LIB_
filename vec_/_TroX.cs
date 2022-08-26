using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.vec_
{
	static public class _TroX
	{
		static public (T, T,T) _ValTup_assumeTro<T>(this IEnumerator<T> seq) {
			seq.MoveNext();
			var t = seq.Current;
			seq.MoveNext();
			var t1 = seq.Current;
			seq.MoveNext();
			return (t,t1, seq.Current);
		}
		static public (T, T,T) _ValTup_assumeTro<T>(this IEnumerable<T> seq) {
			return _ValTup_assumeTro(seq.GetEnumerator());
		}


	}
}
