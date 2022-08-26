using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class DefaultEq<T>
		:IEqualityComparer<T>
	{
		public bool Equals(T x, T y)
		{
			return EqualityComparer<T>.Default.Equals(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			return EqualityComparer<T>.Default.GetHashCode(obj);
			throw new NotImplementedException();
		}
	}
}
