using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{



	[Obsolete(nameof(obj.Eq3<T>))]
	public  class Equal2<T>: EqualityComparer<T>
	{

		private Func<T,T,bool> _comparer;

		public Equal2(Func<T,T,bool>comparer)
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
			return obj.GetHashCode();
		}
	}


}
