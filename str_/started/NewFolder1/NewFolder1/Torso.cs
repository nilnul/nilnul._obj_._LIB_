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
	///
	[Obsolete(nameof(started._DeheadX))]
	public static  class _TorsoX1
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		///
		static public IEnumerable<T> Headless_ofStarted<T>(this IEnumerable<T> _started ) {
			return _started.Skip(1);
		}
	}
}
