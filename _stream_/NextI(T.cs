using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj._stream_
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface NextI<out T>
		:

		_next.MorphI<T>	//they share the same members; but they denotates different semantics: for this type, the next is always a newly generated ones, possibly by caching old ones.
	{
		//T next();

	}

	


}
