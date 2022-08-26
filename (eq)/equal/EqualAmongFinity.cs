using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.equal
{

	/// <summary>
	/// T has finite many instances.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	public partial class EqualAmongFinity<T>: EqualityComparer<T>
		,
		FiniteI
	{

		private Func<T,T,bool> _comparer;

		public EqualAmongFinity(Func<T,T,bool>comparer)
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
