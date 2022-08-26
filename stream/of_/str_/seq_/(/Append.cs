using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.construct_
{
	public static  class _AppendX
	{
		/// <summary>
		/// append default if necessary
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_stream"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		static public IEnumerable<T> _Append_ofStream<T>(this IEnumerable<T> _stream , T x=default(T)) {

			var enumrator = _stream.GetEnumerator();
			while (enumrator.MoveNext())
			{
				yield return enumrator.Current;
			} //never ends
			yield return x;
		}


	}
}
