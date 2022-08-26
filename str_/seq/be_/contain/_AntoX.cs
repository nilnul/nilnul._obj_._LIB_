using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.contain
{
	static public class _AntoX
	{
		static public bool _NotContain<T>(
			IEnumerable<T> _str
			,
			T ele
			,
			IEqualityComparer<T> eq
		) {
			return !_ContainX._Contain(_str, ele, eq);

		}

	}
}
