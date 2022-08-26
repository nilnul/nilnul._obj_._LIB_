using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.equal
{


	/// <summary>
	/// T has infinite many instances.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class EqualAmongInfinity<T>: EqualityComparer<T>
		,InfiniteI
		
	{

		private Func<T,T,bool> _comparer;

		public EqualAmongInfinity(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}





		public override bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public override int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
	}
}
