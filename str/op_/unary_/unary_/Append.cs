using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.op_.unary_
{
	public static  class _AppendX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> Append<T>(this IEnumerable<T> _started , T x) {
			return _started.Concat(new[] { x});
		}
	}
}
