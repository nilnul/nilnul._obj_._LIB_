using System.Collections.Generic;

namespace nilnul.obj.splice_.ofArr_
{
	public abstract class OfSeqA<T>
		:
		OfArrI<T>
		,
		OfSeqI<T>

	{
		public abstract T splice(IEnumerable<T> x);

		public T splice(T[] x)
		{
			return splice((IEnumerable<T>)x);
		}

		
	}



}