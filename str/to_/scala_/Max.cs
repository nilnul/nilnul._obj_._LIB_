using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.to_.scalar_
{
	static public class _MaxOrDefaultX
	{
		static public T Max0default<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {
			if (x.Any())
			{
				return nilnul.obj.str_.started.to_.scala_._MaxX.Max_assumeStarted(x, comparer);
			}
			return default(T);
			
		}


		static public T Max0default<T>(
			this IEnumerable<T> x
			
		)
		{

			return Max0default(x, System.Collections.Generic.Comparer<T>.Default);
		}

		static public T Max0default<T,TComparer>(
			this IEnumerable<T> x
		)
		where TComparer:IComparer<T>,new()
		{
			return Max0default(x,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComparer>.Instance
				);

		}

		[Obsolete(nameof(Max0default))]
		static public T Max<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {
			if (x.Any())
			{
				return nilnul.obj.str_.started.to_.scala_._MaxX.Max_assumeStarted(x, comparer);
			}
			return default(T);
			
		}

		[Obsolete(nameof(Max0default))]
		static public T Max<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{
			return Max0default(x,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComparer>.Instance
				);


			//return x.Any() ? nilnul.objs_.started._MaxX.Max_assumeStarted<T,TComparer>(x) : default(T);
		}

		[Obsolete(nameof(scala_.max_._MappedX))]
		static public T _Max_assumeComp<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			Func<TTarget,TTarget,int> comparer
		) {
			return Max<T,TTarget>(
				x1, map
				,
				new Comp<TTarget>(
					comparer
				)
			);
		}


		[Obsolete(nameof(scala_.max_._MappedX))]
		static public T Max<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {
			return x1.Any()? nilnul.objs_.started._MaxX.Max_assumeStarted(x1, map, comparer):default(T);
		}
		[Obsolete(nameof(scala_.max_._MappedX))]
		static public T _Max_assumeComp<T>(
			this IEnumerable<T> x1

			,
			Func<T,T,int> comparer
		) {
			return Max<T>(
				x1 
				,
				new Comp<T>(
					comparer
				)
			);
		}





	}
}
