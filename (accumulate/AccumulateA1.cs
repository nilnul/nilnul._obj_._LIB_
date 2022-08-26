using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	

	public abstract class AccumulateA1<T> : AccumulateI1<T>
	{
		public T accumulate(IEnumerable<T> arg) {
			return accumulate(new nilnul.obj.str_.Seq<T>(arg));
		}

		public T accumulate(nilnul.obj.str_.Seq<T> seq) {
			return accumulate(
				(StrI1<T>)seq
			);
		}

		public abstract T accumulate(StrI1<T> x);

		public T accumulate(params T[] arg) {
			return accumulate((IEnumerable<T>)arg);
		}
	}
}
