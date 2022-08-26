using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{

	public class Ne<T, TEq> : nilnul.obj.re_.NeI<T>

		where TEq : IEqualityComparer<T>, new()
	{
		public bool ne(T x, T y)
		{
			return !nilnul._obj.Singleton<TEq>.Instance.Equals(x, y);
			//throw new NotImplementedException();
		}

		static public Ne<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Ne<T, TEq>>.Instance;
			}
		}


	}
}
