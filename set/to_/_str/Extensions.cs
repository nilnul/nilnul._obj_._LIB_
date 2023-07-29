using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.to_._str
{
	/// <summary>
	/// convert a set to str. this is in fact sort.
	/// </summary>
	public static class _Extensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="set"></param>
		/// <param name="comparer"></param>
		/// <returns>
		///   will contain duplicate elements. the order of dupliate elements is undefined.
		/// </returns>
		static public IEnumerable<T> SortUnstable<T>(
			
			nilnul.obj.Set<T> set, 
			IComparer<T> comparer //the comparer might be incosistent with the eq in set.
			
			) {

			return 	set.hashSet.OrderBy(x => x, comparer);


		}

		static public List<T> ToList<T>(this Set<T> set ) {

			return set.ToList();
		}

	}
}
