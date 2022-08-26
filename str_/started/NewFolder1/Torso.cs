using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]

	public static  class _TorsoX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		///<see cref="obj.str_.started._MainX"/>
		[Obsolete("torso is changed semantically as body/tail/deheaded")]
		static public IEnumerable<T> Torso<T>(this IEnumerable<T> _started ) {
			return _started.Take(_started.Count()-1);
		}
	}
}
