using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	public class Eq<T>
		:
		nilnul.obj.Box_pub<IEqualityComparer<T>>
		,
		IEqualityComparer<(T, T)>
		,
		IEqualityComparer<Tuple<T, T>>
		,
		IEqualityComparer<nilnul.obj.CoI2<T>>
	{
		public Eq(IEqualityComparer<T> val) : base(val)
		{
		}
		public bool _Equals(T x, T x1, T y, T y1)
		{
			return boxed.Equals(x, y) && boxed.Equals(x1, y1);
		}

		public bool Equals((T, T) x, (T, T) y)
		{
			return Equals(x.Item1, y.Item1) && boxed.Equals(x.Item2, y.Item2);
		}

		public bool Equals(Tuple<T, T> x, Tuple<T, T> y)
		{
			return _Equals(x.Item1, x.Item2, y.Item1, y.Item2);
		}
		public int _GetHashCode(T item, T item1)
		{
			return boxed.GetHashCode(item) & boxed.GetHashCode(item1);
		}

		public int GetHashCode((T, T) obj)
		{
			return _GetHashCode(obj.Item1, obj.Item2);
		}

		public int GetHashCode(Tuple<T, T> obj)
		{
			return _GetHashCode(obj.Item1, obj.Item2);

		}

		public bool Equals(CoI2<T> x, CoI2<T> y)
		{
			return _Equals(x.component, x.component1, y.component, y.component1);
		}

		public bool Equals(Co<T> x, Co<T> y)
		{
			return Equals((CoI2<T>)x, (CoI2<T>)y);
		}

		public int GetHashCode(CoI2<T> obj)
		{
			return _GetHashCode(obj.component, obj.component1);
		}
		public int GetHashCode(Co<T> x)
		{
			return GetHashCode(
				(CoI2<T>)x
			);
		}
	}
}
