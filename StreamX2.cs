using System.Collections.Generic;


namespace nilnul.obj
{
	static public class StreamX2
	{
		static public IEnumerable<T> Fetch<T>(this StreamI2<T> next, int count) {
			return nilnul.obj.stream._FetchX.Fetch(next, count);
		}

	}


}
