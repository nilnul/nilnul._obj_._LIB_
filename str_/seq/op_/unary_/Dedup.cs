using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.op_.unary_
{
	static public class _DedupX
	{
		//[Obsolete( nameof(IEnumerable<T>.Distinct<T>))]
		[Obsolete( "use IEnumerable<T>.Distinct directly")]

		static public IEnumerable<T> Op<T>(IEnumerable<T> par, IEqualityComparer<T> eleEq)
		{
			return par.Distinct(eleEq);
		}
	}
}
