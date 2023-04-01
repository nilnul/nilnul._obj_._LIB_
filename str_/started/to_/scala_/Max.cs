using nilnul.obj.str_.started.to_.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.to_.scala_
{
	static public class _MaxX
	{
		static public T Max_assumeStarted<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {

			return new nilnul.obj.op_.binary_.max.Cumulator<T>(
				x.First(), comparer
			).cumulate(
				nilnul.objs_.started._TailX._Tail(x)
			);
		}

		static public T Max_assumeStarted<T>(
			this IEnumerable<T> x
	
		) {

			return Max_assumeStarted<T>(x, Comparer<T>.Default);
		}

	

		static public T Max_assumeStarted<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return new nilnul.obj.op_.binary_.max.cumulator_.ComparerDefault<T,TComparer>(
				x.First()
			).cumulate(
				x._Tail()
			);
		}



	}
}
