using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// find any that is equal to
	/// </summary>
	public static class _IndexOfX
	{

		public static int IndexOf_retCountIfNoFound<T>(this IEnumerable<T> list, IEqualityComparer<T> eq, T el)
		{
			return _FindIndexX.FindIndex(list, x => eq.Equals(x, el));
		}

		static public int IndexOf<T>(this IEnumerable<T> list, IEqualityComparer<T> elEq, T el) {

			return IndexOf_byBag(list, elEq, el);

		}

		static public int IndexOf<T,TEl>(this IEnumerable<T> list,  T el)
			where TEl:IEqualityComparer<T>,new()
		{

			return IndexOf(list, nilnul.obj.SingletonByDefault<TEl>.Instance, el);

		}


		
		public static int IndexOf_byBag<T>(this IEnumerable<T> list, IEqualityComparer<T> finder, T el)
		{
			return _FindIndexX.FindIndex(list, x => finder.Equals(x, el));
			
		}


		// find the index of an item in the collection similar to List<T>.FindIndex()
		public static int IndexOf_byList<T>(this IEnumerable<T> list, IEqualityComparer<T> finder, T el)
		{
			return _FindIndexX.FindIndex_byToList(list, x=>finder.Equals(x,el));
		}
		public static int IndexOf_byArray<T>(this IEnumerable<T> list, IEqualityComparer<T> finder, T el)
		{

			return _FindIndexX.FindIndex_byToArray(list,x=>finder.Equals(x,el));
		}

		public static int IndexOf_byLoop<T>(this IEnumerable<T> list, IEqualityComparer<T> finder, T el)
		{
			return _FindIndexX.FindIndex_byLoop(list, x => finder.Equals(x, el));
		}




	}
}