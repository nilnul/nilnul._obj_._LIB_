using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	[Obsolete(nameof(obj.str.to_.scalar_._MinOrDefaultX))]
	static public class _MinOrDefaultX
	{
		static public T Min<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {

			return x.Any()? nilnul.objs_.started._MinX.Min_assumeStarted(x,comparer):default(T);
		}


		static public T Min<T, TTarget>(
	this IEnumerable<T> x1
	,
	Func<T, TTarget> map
	,
	IComparer<TTarget> comparer
)
		{
			return x1.Any() ? nilnul.objs_.started._MinX.Min_assumeStarted(x1, map, comparer) : default(T);
		}


		static public T Min<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{

			return x.Any() ? nilnul.objs_.started._MinX.Min_assumeStarted<T, TComparer>(x) : default(T);

		}



	}
}
