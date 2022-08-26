using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_
{
	public class OvComparer<T>
		: nilnul.obj.Box<IComparer<T>>
		,
		IEqualityComparer<T>
	{
		public OvComparer(IComparer<T> val) : base(val)
		{
		}

		public bool Equals(T x, T y)
		{
			return boxed.Compare(x, y) == 0;
			//throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			return 0;
			//throw new NotImplementedException();
		}
	}
}
