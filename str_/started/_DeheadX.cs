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
	///		torso
	///		body
	///		tail
	public static  class _DeheadX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		///
		static public IEnumerable<T> _Dehead_assumeStarted<T>(this IEnumerable<T> _started ) {
			return _started.Skip(1);
		}
	}
}
