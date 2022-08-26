using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(_DetoeX))]
	public static  class _MainX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> Main<T>(this IEnumerable<T> _started ) {
			if (_started.Any())
			{
				return str_.started._MainX.Main(_started);

			}
			else
			{
				return System.Linq. Enumerable.Empty<T>();
			}
			//return _started.Take(_started.Count()-1);
		}
	}
}
