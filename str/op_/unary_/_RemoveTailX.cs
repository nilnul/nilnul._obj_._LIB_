using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.of_.unary_
{
	/// <summary>
	/// remove tail
	/// </summary>
	public static  class _RemoveTailX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> _RemoveTail_1valid<T>(
			this IEnumerable<T> _started, int x
		) {
			return _started.Reverse().Skip(x).Reverse();
		}
	}
}
