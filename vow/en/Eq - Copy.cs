using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._avow_;

namespace nilnul.obj.vow.ed
{
	[Obsolete(nameof(en))]
	public class Eq<T>
		: IEqualityComparer<Ed<T>>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}


		public Eq(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}
		public bool Equals(Ed<T> x, Ed<T> y)
		{
			return _eq.Equals(x.vowed, y.vowed);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Ed<T> obj)
		{
			return _eq.GetHashCode(obj.vowed);

			//throw new NotImplementedException();
		}



	}
}
