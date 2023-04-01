using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.splice_.ofSeq_
{
	public abstract class OfArrA<T>
		:
		OfArrI<T>
		,
		OfSeqI<T>

	{
		public T splice(IEnumerable<T> x) {
			return splice(x.ToArray());
		}

		public abstract T splice(T[] x);

		
	}



}