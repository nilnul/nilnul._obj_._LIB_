using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	static public class _Main1toeX
	{
	

		/// <summary>
		/// must enumerate to get the last.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		static public (IEnumerable<T>, T) Main1toe<T>(this IEnumerable<T> _started){
			return (_started.Main(), _started.Last());
		}
	}
}
