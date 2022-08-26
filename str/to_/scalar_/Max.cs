using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.to_.scalar_
{
	static public class _MaxOrDefaultX
	{
		static public T Max<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {
			if (x.Any())
			{
				return nilnul.objs_.started._MaxX.Max_assumeStarted(x, comparer);
			}
			return default(T);
			
		}

		static public T Max<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {
			return x1.Any()? nilnul.objs_.started._MaxX.Max_assumeStarted(x1, map, comparer):default(T);
		}

		static public T Max<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return x.Any() ? nilnul.objs_.started._MaxX.Max_assumeStarted<T,TComparer>(x) : default(T);
		}



	}
}
