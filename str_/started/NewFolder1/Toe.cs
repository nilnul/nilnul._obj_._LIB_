using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	/// <summary>
	/// the last element
	/// </summary>
	/// <remarks>
	/// alias:
	///		last
	///		toe
	///		tip
	///	except toe, other part is called <see cref=""/>
	///		
	/// </remarks>
	///
	[Obsolete()]

	public static  class _ToeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref="">if empty</exception>
		static public T Toe<T>(this IEnumerable<T> _started ) {
			return _started.Last();
		}
	}
}
