using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._accumulate_
{
	

	public abstract class OfSeqA<T> : OfElI<T>
	{
		public abstract T accumulate(IEnumerable<T> arg);

		

		public T accumulate(params T[] arg) {
			return accumulate((IEnumerable<T>)arg);
		}
	}
}
