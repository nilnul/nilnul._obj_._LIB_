using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.vec_
{
	static public class _CoX
	{
		static public (T, T) _ValTup_assumeCo<T>(this IEnumerator<T> seq) {
			seq.MoveNext();
			var t = seq.Current;
			seq.MoveNext();
			return (t,seq.Current);
		}
		static public (T, T) _ValTup_assumeCo<T>(this IEnumerable<T> seq) {
			return _ValTup_assumeCo(seq.GetEnumerator());
		}


	}
}
