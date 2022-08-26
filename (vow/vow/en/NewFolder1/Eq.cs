using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._avow_;

namespace nilnul.obj.avow.ed
{
	[Obsolete(nameof(vow.ed.Eq<T>))]
	public class Eq<T>
		: IEqualityComparer<_ed_.EdI<T>>
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
		public bool Equals(_ed_.EdI<T> x, _ed_.EdI<T> y)
		{
			return _eq.Equals(x.avowed, y.avowed);
			//throw new NotImplementedException();
		}

		public int GetHashCode(_ed_.EdI<T> obj)
		{
			return _eq.GetHashCode(obj.avowed);

			//throw new NotImplementedException();
		}
	}
}
