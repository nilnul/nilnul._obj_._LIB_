using System;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.obj
{
	//[Serializable]
	public abstract class SeqA<T> : IEnumerable<T>
	{
		public abstract IEnumerator<T> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}







}
