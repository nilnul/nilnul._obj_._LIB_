using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.eq_
{
	public class AsObj<T> :
		IEqualityComparer<T>
	{
		public bool Equals(T x, T y)
		{
			return object.Equals(x, y);
		}
		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
		static public AsObj<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<AsObj<T>>.Instance;
			}
		}




	}

}
