using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.to_.scala_
{
	/// <summary>
	/// use <see cref="_MaxX"/>
	/// </summary>
	static public class _MinX
	{
		static public T Min_assumeStarted<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {

			return _MaxX.Max_assumeStarted(
				x
				,
				new nilnul.obj.comp.Converse<T>(comparer)
			);
		}

		static public T Min_assumeStarted<T>(
			this IEnumerable<T> x
			
		)
		{

			return Min_assumeStarted(
				x, 
				 Comparer<T>.Default
			);
		}


		static public T Min_assumeStarted<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return Min_assumeStarted(
				x, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComparer>.Instance
			);
		}




	}
}
