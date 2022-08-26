using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	public static class _IndexOfX
	{
		/// <summary>
		/// note if item not found, result is length and not -1!
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int IndexOf_byTakeWhile_notFoundIsCount<T>(this IEnumerable<T> list, T findee, IEqualityComparer<T> eq)
		{
			return list.TakeWhile(i =>  !eq.Equals(findee,i) ).Count();
		}



		public static int IndexOf<T>(this IEnumerable<T> list, T findee, IEqualityComparer<T> eq)
		{
			
			return list.Select((item, index) => new
			{
				item,	// if you don't name the anonymous properties they are the variable names
				index
			}).Where(
				p => eq.Equals(p.item,findee)
			)
			.Select(p => p.index ).DefaultIfEmpty(-1)
			.First() ;
		}

		public static int IndexOf<T>(this IEnumerable<T> list, T finder)
		{

			return IndexOf(list, finder, EqualityComparer<T>.Default);
		}


		/// <summary>
		///  find the index of an item in the collection similar to List<T>.FindIndex()
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int IndexOf_byToList<T>(this IEnumerable<T> list, T finder)
		{
			return list.ToList().IndexOf(finder);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int IndexOf_byToArray<T>(this IEnumerable<T> list, T finder)
		{
			return Array.IndexOf( list.ToArray(),finder);
		}


		public static int IndexOf_byLoop<T>(this IEnumerable<T> list, T finder, IEqualityComparer<T> eq)
		{
			int index = 0;
			foreach (var item in list)
			{
				if (eq.Equals(finder,item))
				{
					return index;
				}

				index++;
			}

			return -1;
		}

		public static int IndexOf_byLoop<T>(this IEnumerable<T> list, T finder )
		{
			return IndexOf_byLoop(list, finder, EqualityComparer<T>.Default);
		}



	}
}
