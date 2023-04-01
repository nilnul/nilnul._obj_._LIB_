using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.to_.str_
{
	[Obsolete(nameof(cast_._DeheadX))]
	public static  class _TailX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> _Tail<T>(this IEnumerable<T> _started ) {
			return _started.Skip(1);
		}
	}
}
