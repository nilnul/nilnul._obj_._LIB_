using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.to_.scala_.min_
{
	/// <summary>
	/// the comparer is a mapped comparer
	/// </summary>
	static public class _MappedX
	{
		static public T Min_assumeStarted<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {
			return scala_._MinX.Min_assumeStarted(
				x1
				,
				new nilnul.obj.comp_.ByTag<T, TTarget>(map, comparer)
			);
		}
		static public T Min_assumeStarted<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
		
		) {
			return Min_assumeStarted(
				x1
				,
				map
				,
				Comparer<TTarget>.Default
			);

		}
		static public T Min_assumeStarted<T,TTarget,TComp>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
		)
			where TComp:IComparer<TTarget>,new()
		{
			return Min_assumeStarted(
				x1
				,
				map
				,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComp>.Instance
			);
		}
	}
}