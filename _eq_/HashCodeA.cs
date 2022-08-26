using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._eq_
{
	public abstract class HashCodeA<T> : IEqualityComparer<T>
	{
		public abstract bool Equals(T x, T y);

		/// <summary>
		/// especially for collection,it's unncessary as hashCode is used inner of collection; and also it's time-consuming for collection.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public int GetHashCode(T obj)
		{
			return 0;
			//throw new NotImplementedException();
		}
	}
}
