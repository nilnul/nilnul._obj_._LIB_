using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	static public class _MaxesX
	{
		static public System.Collections.Generic.List<T> Maxes<T>(
			this IEnumerable<T> x
			,
			IComparer<T> comparer
		) {
			
			var r =new System.Collections.Generic.List<T>();

			foreach (var item in x)
			{
				if (r.Any())
				{
					var compared = comparer.Compare(item, r.First());
					if (compared ==0 )
					{
						r.Add(item);
					} else
					if (compared >0)
					{
						r.Clear();
						r.Add(item);
					}
				}
				else
				{
					r.Add(item);
				}
			}
			return r;



			
		}

		static public System.Collections.Generic.List<T> Maxes<T,TTarget>(
			this IEnumerable<T> x1
			,
			Func<T,TTarget> map
			,
			IComparer<TTarget> comparer
		) {

			return Maxes(
				x1,

				new nilnul.obj.comp_.ByTag<T,TTarget>(map,comparer)
			); ;
			


		}

		static public System.Collections.Generic.List<T> Maxes<T,TComparer>(
			this IEnumerable<T> x
			
		)
			where TComparer:IComparer<T>,new()
		{


			return Maxes(x, nilnul.obj_.Singleton<TComparer>.Instance);
				
		}

		static public System.Collections.Generic.List<T> Maxes<T>(
			this IEnumerable<T> x

		)
		{


			return Maxes(x, Comparer<T>.Default);
				
		}



	}
}
