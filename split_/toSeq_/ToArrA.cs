using System.Collections.Generic;

namespace nilnul.obj.split_.toSeq_
{
	public abstract class ToArrA<T>
		:
		ToArrI<T>
		,
		ToSeqI<T>

	{
		public IEnumerable<T> split(T x) { return split2arr(x); }

		public abstract T[] split2arr(T x);
	}



}