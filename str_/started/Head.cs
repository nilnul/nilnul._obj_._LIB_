using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	/// <summary>
	/// the first element
	/// </summary>
	/// <remarks>
	/// alias:
	///		first
	///		head
	///		
	/// </remarks>
	/// 
	public static  class _HeadX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		static public T _Head_assumeStarted<T>(this IEnumerable<T> _started ) {
			return _started.First();
		}
	}
}
