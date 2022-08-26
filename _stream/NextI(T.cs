using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._stream
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface NextI<T> {
		T next();

	}


}
