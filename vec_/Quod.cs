using System;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.obj.vec_
{

	public class Quod<T>
		:
		Tuple<T, T, T, T> // we neednot to repeat the typeparameter thrice.
		,
		VecI<T>
	{
		public Quod(T item1, T item2, T item3, T item4) : base(item1, item2, item3, item4)
		{
		}

		public Quod((T,T,T,T) x):this(
			x.Item1
			,
			x.Item2
			,
			x.Item3
			,
			x.Item4
		)
		{

		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return base.Item1;
			yield return base.Item2;
			yield return base.Item3;
			yield return base.Item4;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}

		static public implicit operator Quod<T>(
	(T, T, T,T) x
)
		{
			return new Quod<T>(x);
		}
		static public implicit operator (T, T, T,T)(
			Quod<T> x
		)
		{
			return (x.Item1, x.Item2, x.Item3, x.Item4);
		}


	}
}
