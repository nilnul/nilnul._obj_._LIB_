using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		Detoe
	///		toeless.
	///
	[Obsolete(nameof(started._DetoeX))]
	public static  class _MainX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> Main<T>(this IEnumerable<T> _started ) {
			return _started.Take(_started.Count()-1);
		}
	}
}
