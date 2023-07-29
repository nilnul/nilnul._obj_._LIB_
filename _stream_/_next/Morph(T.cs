using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj._stream_._next
{

	/// <summary>
	/// morph means the instance generates not a new one, but changes the old one. care must be taken when you enumerate this, the returned one will change in each loop, so you must cache previous ones if you wang to keep them along with the new ones.
	/// <see cref="nilnul.num.Permutate"/> for an exmple where the permutate morphs the returned referenced value in each round of enumeration;
	/// To generate a new one each time, use <see cref="nameof(_stream_.NextI)"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface MorphI<out T> {
		T next();

	}

	


}
