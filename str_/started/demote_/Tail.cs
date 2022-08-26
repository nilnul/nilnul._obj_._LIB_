using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started.demote_
{
	public static  class _TailX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> _Eval<T>(this IEnumerable<T> _started ) {
			return _started.Skip(1);
		}
	}
}
