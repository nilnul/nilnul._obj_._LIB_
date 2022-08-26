using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface StreamI2<out T> :nilnul.obj._stream_.NextI<T>
		,StreamI_blank_ofEl<T>
 {
		//T next();

	}

	static public class StreamX2
	{
		static public IEnumerable<T> Fetch<T>(this StreamI2<T> next, int count) {
			return nilnul.obj.stream._FetchX.Fetch(next, count);
		}

	}


}
