﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started
{
	static public class _MinX
	{
		static public T Min_assumeStarted<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {

			return new nilnul.obj.op_.binary_.min.Cumulator<T>(
				x.First(), comparer
			).cumulate(
				nilnul.objs_.started._TailX._Tail(x)
			);
		}

		static public T Min_assumeStarted<T, TTarget>(
	this IEnumerable<T> x1
	,
	Func<T, TTarget> map
	,
	IComparer<TTarget> comparer
)
		{
			return Min_assumeStarted(
				x1
				,
				new nilnul.obj.comp_.ByTag<T, TTarget>(map,comparer)
			);

			//return x1.Aggregate((x, y) => comparer.Compare(map(x), map(y)) <= 0 ? x : y);
		}

		static public T Min_assumeStarted<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return new nilnul.obj.op_.binary_.min.cumulator_.ComparerDefault<T,TComparer>(
				x.First()
			).cumulate(
				x._Tail()
			);
		}



	}
}
