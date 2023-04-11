using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.unary_
{
	/// <summary>
	/// remove last one if there is one
	/// </summary>
	public static  class _DetoeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> Detoe<T>(this IEnumerable<T> _started ) {
			if (_started.Any())
			{
				return str_.started._DetoeX._Detoe_assumeStarted(_started);

			}
			else
			{
				return System.Linq. Enumerable.Empty<T>();
			}
			//return _started.Take(_started.Count()-1);
		}
	}
}
