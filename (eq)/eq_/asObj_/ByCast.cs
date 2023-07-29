using System.Collections.Generic;

namespace nilnul.obj.eq_.asObj_
{
	public class ByCast<T>
		:IEqualityComparer<T>
	{


		public bool Equals(T x, T y)
		{
			/// can null be casted as obj? <see cref="test"/>
			return (object)x == (object)y;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj">
		/// not nul or else nullreference exception.
		/// </param>
		/// <returns></returns>
		public int GetHashCode(T obj)
		{
			
			return ((object)obj).GetHashCode();
		}


		public  bool eq2default( T value)=> Equals(value, default(T));

		static public ByCast<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByCast<T>>.Unison;
			}
		}

	}


}
