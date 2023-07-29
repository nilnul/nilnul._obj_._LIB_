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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj">
		///not null or else nullReferenceException.
		/// </param>
		/// <returns></returns>
		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}

		static public AsObj<T> Singleton
		{
			
			get
			{
				return nilnul._obj.typ_._UnisonX<AsObj<T>>.Unison;
			}
		}



	}

}
