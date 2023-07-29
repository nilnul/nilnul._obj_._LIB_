using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{



	/// <summary>
	/// take func as comparer. getHashCode returns 0 for every.
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public  class Eq_ofFunc<T>: EqualityComparer<T>
		,EqI<T>
	{

		private Func<T,T,bool> _comparer;
		private Func<T,int> _hasher;

		public Eq_ofFunc(Func<T,T,bool>comparer, Func<T,int> hasher)
		{
			this._comparer = comparer;
			this._hasher = hasher;

		}
		public Eq_ofFunc(Func<T,T,bool>comparer):this(comparer, (x)=>0)
		{

		}

		public override bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public override int GetHashCode(T obj)
		{
			return _hasher(obj);

			/// the following is not correct as the <see cref="_comparer"/> may make two object equal even when there hashCodes differ.

			return obj.GetHashCode();
		}
	}


}
