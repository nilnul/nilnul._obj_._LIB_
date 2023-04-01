using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// alias: scala
namespace nilnul.obj.str.to_.scalar_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		min0default
	static public class _MinOrDefaultX
	{
		static public T Min0default<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		)
		{

			return x.Any() ? nilnul.objs_.started._MinX.Min_assumeStarted(x, comparer) : default(T);
		}



		static public T Min0default<T>(
			this IEnumerable<T> x

		)
		{
			return Min0default(x, System.Collections.Generic.Comparer<T>.Default);

		}
		static public T Min0default<T, TComp>(
			this IEnumerable<T> x
		)
			where TComp : IComparer<T>, new()

		{
			return Min0default(x, System.Collections.Generic.Comparer<T>.Default);

		}

		[Obsolete(nameof(Min0default))]
		static public T Min<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		)
		{

			return x.Any() ? nilnul.objs_.started._MinX.Min_assumeStarted(x, comparer) : default(T);
		}


		[Obsolete(nameof(Min0default))]
		static public T Min<T, TComparer>(
			this IEnumerable<T> x

		)
			where TComparer : IComparer<T>, new()
		{

			return x.Any() ? nilnul.objs_.started._MinX.Min_assumeStarted<T, TComparer>(x) : default(T);

		}


		[Obsolete(nameof(scala_.min_._MappedX))]
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


		[Obsolete(nameof(scala_.min_._MappedX))]

		static public T _Min_assumeComp<T, TTarget>(
		this IEnumerable<T> x1
		,
		Func<T, TTarget> map
		,
		Func<TTarget, TTarget, int> comparer
	)
		{
			return Min<T, TTarget>(
				x1, map
				,
				new Comp<TTarget>(
					comparer
				)
			);
		}

		[Obsolete(nameof(scala_.min_._MappedX))]
		static public T _Min_assumeComp<T>(
			this IEnumerable<T> x1

			,
			Func<T, T, int> comparer
		)
		{
			return Min<T>(
				x1
				,
				new Comp<T>(
					comparer
				)
			);
		}



	}
}
