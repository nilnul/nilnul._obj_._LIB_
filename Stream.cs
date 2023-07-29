using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace nilnul.obj
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface StreamI2<out T>
		:
		nilnul.obj._stream_.NextI<T>
		,
		StreamI_blank_ofEl<T>
		,
		IStream<T>
 {
		//T next();

	}


}
