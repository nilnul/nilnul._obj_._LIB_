using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	static public class _SkipX
	{
		/// <summary>
		/// defered fetch
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="next"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		static public void Skip<T>(this nilnul.obj.StreamI2<T> next, BigInteger count) {
			for (BigInteger i = 0; i < count; i++)
			{
				 next.next();
			}
		}
		


	}
}
