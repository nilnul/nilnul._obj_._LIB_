using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	/// <summary>
	/// often we introduce infinity for the purpose of simplifying how to get arbitrary finity.
	/// </summary>
	static public class _FetchX
	{
		/// <summary>
		/// defered fetch
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="next"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		static public IEnumerable<T> _FetchDefered<T>(this nilnul.obj.StreamI2<T> next, int count) {
			for (int i = 0; i < count; i++)
			{
				yield return next.next();
			}
		}
		static public T[] Fetch<T>(this nilnul.obj.StreamI2<T> next, int count) {
			return _FetchDefered(next, count).ToArray();
		}


	}
}
