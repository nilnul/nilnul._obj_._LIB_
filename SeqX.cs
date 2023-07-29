using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	/*
	 if it's finite, we call it Repeated;
	if it's infinite, we call it Recured.
	 */
	/// <summary>
	/// <see cref="IStr"/> or <see cref="IStream"/>
	/// </summary>
	static public class SeqX
	{
		static public void Each<T>(this IEnumerable<T> x, Action<T> action) {
			foreach (var item in x)
			{
				action(item);
			}
		}

		/// <summary>
		/// make this greedy rather than lazy
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="x"></param>
		static public void Each<T>(this IEnumerable<T> x) {
			foreach (var item in x)
			{
			}
		}

	}
}
