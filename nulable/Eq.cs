using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable
{
	public class Eq<T> : nilnul.obj.Box<IEqualityComparer<T>>, IEqualityComparer<T>
	{
		public Eq(IEqualityComparer<T> eq) : base(eq)
		{

		}
		public bool Equals(T x, T y)
		{
			if (object.ReferenceEquals(x, null) )
			{
				if (object.ReferenceEquals(y  , null))
				{
					return true;
				}
				return false;
			}
			if (object.ReferenceEquals(y, null))
			{
				return false;
			}
			return boxed.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			if (object.ReferenceEquals(obj ,null))
			{
				return 0;
			}

			return this.boxed.GetHashCode(obj);
			//throw new NotImplementedException();
		}
	}

}
