using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	static public class _MinsX
	{
		static public System.Collections.Generic.List<T> Mins<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {
			return _MaxesX.Maxes(
				x,
				new nilnul.obj.comparer.Converse<T>(comparer)
			);



			
		}

		static public System.Collections.Generic.List<T> Mins<T,TTarget>(
			this IEnumerable<T> x
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {

				return _MaxesX.Maxes(
				x,
				map,
				new nilnul.obj.comparer.Converse<TTarget>(comparer)
			);
		


		}

		static public System.Collections.Generic.List<T> Mins<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return Mins(x, nilnul.obj_.Singleton<TComparer>.Instance);
				
		}

		static public System.Collections.Generic.List<T> Mins<T>(
			this IEnumerable<T> x

		)
		{


			return Mins(x, Comparer<T>.Default);
				
		}



	}
}
