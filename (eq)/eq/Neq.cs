using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	public class Neq<T, TEq> : nilnul.obj.re_.NeqI<T>

		where TEq : IEqualityComparer<T>, new()
	{
		public bool neq(T x, T y)
		{
			return !nilnul._obj.Singleton<TEq>.Instance.Equals(x, y);
			//throw new NotImplementedException();
		}

		static public Neq<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Neq<T, TEq>>.Instance;
			}
		}


	}
}
