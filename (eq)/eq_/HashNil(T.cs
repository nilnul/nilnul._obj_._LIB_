using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.eq_
{



	/// <summary>
	/// take func as comparer. getHashCode returns 0 for every.
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public  class HashNil<T>: EqualityComparer<T>
		,EqI<T>
	{

		private Func<T,T,bool> _comparer;

		public HashNil(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}


		public override bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public override int GetHashCode(T obj)
		{
			return 0;

			/// the following is not correct as the <see cref="_comparer"/> may make two object equal even when there hashCodes differ.

			return obj.GetHashCode();
		}
	}


}
