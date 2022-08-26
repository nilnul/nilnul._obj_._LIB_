using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set._eq_
{
	public abstract class HashCodeA<T> : IEqualityComparer<T>
	{
		public abstract bool Equals(T x, T y);

		public int GetHashCode(T obj)
		{
			return 0;
			//throw new NotImplementedException();
		}
	}
}
