using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	public static class _FindIndexX
	{
		/// <summary>
		/// note if item not found, result is length and not -1!
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int FindIndex_notFoundIsCount<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			return list.TakeWhile(i => !finder(i)).Count();
		}



		public static int FindIndex<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			
			return list.Select((item, index) => new
			{
				item,	// if you don't name the anonymous properties they are the variable names
				index
			}).Where(p => finder(p.item))
				.Select(p => p.index + 1)
			   .FirstOrDefault() - 1;
		}


		/// <summary>
		///  find the index of an item in the collection similar to List<T>.FindIndex()
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int FindIndex_byToList<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			return list.ToList().FindIndex(finder);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="finder"></param>
		/// <returns></returns>
		public static int FindIndex_byToArray<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			return list.ToArray().FindIndex(finder);
		}


		public static int FindIndex_byLoop<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			int index = 0;
			foreach (var item in list)
			{
				if (finder(item))
				{
					return index;
				}

				index++;
			}

			return -1;
		}



	}
}
