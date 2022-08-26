using System;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.obj.vec_
{
	public class Co<T>
		:
		Tuple<T, T> // we neednot to repeat the typeparameter twice.
		,
		VecI<T>
	{
		public Co(T item1, T item2) : base(item1, item2)
		{
		}
		public Co((T,T) x):this(x.Item1,x.Item2)
		{

		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return base.Item1;
			yield return base.Item2;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}

		static public implicit operator Co<T>(
	(T, T) x
)
		{
			return new Co<T>(x);
		}
		static public implicit operator (T, T)(
			Co<T> x
		)
		{
			return (x.Item1, x.Item2);
		}


	}
}
