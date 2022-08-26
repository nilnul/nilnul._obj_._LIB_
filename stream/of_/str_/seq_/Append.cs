using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.of_.seq_
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
		static public IEnumerable<T> Seq<T>(this IEnumerable<T> _stream , T x=default(T)) {

			var enumrator = _stream.GetEnumerator();
			while (enumrator.MoveNext())
			{
				yield return enumrator.Current;
			} //never ends
			while (true)
			{
				yield return x;

			}
		}

		/// <summary>
		/// append null 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_stream"></param>
		/// <returns></returns>
		static public IEnumerable<T?> Seq_ovStruct<T>(this IEnumerable<T> _stream )
			where T:struct

		{

			return Seq<T?>(_stream.Select(x => (T?)x), null);
		}



	}

	
}
