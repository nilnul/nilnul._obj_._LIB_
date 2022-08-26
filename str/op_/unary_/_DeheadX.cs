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
		static public IEnumerable<T> Dehead<T>(this IEnumerable<T> _started ) {
			
			return _started.Skip(1);
		}
	}
}
