using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_.str.be_
{
	static public class _NotContainX
	{
		static public bool NotContain<T>(this IEnumerable<T> seq, T el, IEqualityComparer<T> eq) {
			return !seq.Contains(el,eq);
		}

		static public bool NotContain<T, TEq>(this IEnumerable<T> seq, T eq)
			where TEq : IEqualityComparer<T>, new()
		{
			return NotContain(seq, eq, nilnul.obj_.Singleton<TEq>.Instance);
		}
		static public bool NotContain<T>(this IEnumerable<T> seq, T eq)
		{
			return NotContain(seq, eq, EqualityComparer<T>.Default);
		}



	}
}
