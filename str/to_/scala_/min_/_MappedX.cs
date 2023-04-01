using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.to_.scala_.min_
{
	/// <summary>
	/// the comparer is a mapped comparer
	/// </summary>
	static public class _MappedX
	{
		static public T Min0default<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {
			return scalar_._MinOrDefaultX.Min(
				x1
				,
				new nilnul.obj.comp_.ByTag<T, TTarget>(map, comparer)
			);
		}
		static public T Min0default<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
		
		) {
			return Min0default(
				x1
				,
				map
				,
				System.Collections.Generic.	Comparer<TTarget>.Default
			);

		}
		static public T Min0default<T,TTarget,TComp>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
		)
			where TComp:IComparer<TTarget>,new()
		{
			return Min0default(
				x1
				,
				map
				,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComp>.Instance
			);
		}
	}
}