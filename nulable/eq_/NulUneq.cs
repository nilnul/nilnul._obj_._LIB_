using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.eq_
{
	public class NulUneq<T> : nilnul.obj.Box<IEqualityComparer<T>>, IEqualityComparer<T>
	{
		public NulUneq(IEqualityComparer<T> eq) : base(eq)
		{

		}
		public bool Equals(T x, T y)
		{
			if (object.ReferenceEquals(x  ,null))
			{
				
				return false;
			}
			if (object.ReferenceEquals(y ,null))
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

	public class NulUneq<T, TEq> : NulUneq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public NulUneq() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public NulUneq<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulUneq<T,TEq>>.Instance;
			}
		}
	}
}
