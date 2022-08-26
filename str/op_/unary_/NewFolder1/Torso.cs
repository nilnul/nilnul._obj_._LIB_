using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		torso
	///		body
	///		tail
	///
	[Obsolete(nameof(op_.unary_._DeheadX))]
	public static  class _TorsoX
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
