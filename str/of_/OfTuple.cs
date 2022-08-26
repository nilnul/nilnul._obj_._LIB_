using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.of_
{
	static public class _OfTupleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="tuple">
		/// better if it's ov{T}
		/// </param>
		/// <returns></returns>
		public static IEnumerable<T> ToSeq<T>(this ITuple tuple)
		{
			for (var n = 0; n < tuple.Length; n++) yield return (T)tuple[n];
		}

		public static IEnumerable<T> ToSeq<T>(this (T,T) tuple)
		{
			return ToSeq<T>( (ITuple)tuple);
		}

		public static IEnumerable<T> ToSeq<T>(this (T,T,T) tuple)
		{
			return ToSeq<T>( (ITuple)tuple);
		}


	}

}
