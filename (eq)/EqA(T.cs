using System.Collections.Generic;

namespace nilnul.obj
{
	public abstract class EqA<T>
		: IEqualityComparer<T>
		,
		_eq_.NeI<T>
	{
		public abstract bool Equals(T x, T y);
		public abstract int GetHashCode(T obj);

		public bool ne(T a, T b)
		{
			return !Equals(a, b);
		}

	}


}
