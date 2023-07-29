using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider.to_
{
	static public class _ToSeqX
	{
		

		public static IEnumerable<T> AsSeq<T>(this obj.stream_.SliderI<T> x)
		{
			while (true)
			{
				yield return x.current;
				x.moveNext();
			}
		}
		public static IEnumerable<T> AsSeq<T>(this obj.stream_._slider.SkidI<T> x)
		{
			while (true)
			{
				yield return x.current;
				x.moveNext();
			}
		}


		public static IEnumerator<T> AsEnumer<T>(this obj.stream_.SliderI<T> x)
		{
			while (true)
			{
				yield return x.current;
				x.moveNext();
			}
		}

		public static IEnumerator<T> AsEnumer<T>(this obj.stream_._slider.SkidI<T> x)
		{
			while (true)
			{
				yield return x.current;
				x.moveNext();
			}
		}
	}
}
