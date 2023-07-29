using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.to_
{
	static public class _ToSeqX
	{
		

		public static IEnumerator<T> AsSeq<T>(this obj.StreamI2<T> x)
		{
			while (true)
			{
				yield return x.next();

			}

		}

		public static IEnumerator<T> AsSeq<T>(this obj._stream_.NextI<T> x)
		{
			while (true)
			{
				yield return x.next();

			}

		}


		
	}
}
