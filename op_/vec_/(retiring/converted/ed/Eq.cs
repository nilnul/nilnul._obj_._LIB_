using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op._ed_;

namespace nilnul.obj.op.ed
{

	public class Eq<T>
		: IEqualityComparer<_ed_.EdI<T>>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			//set { _eq = value; }
		}

		public Eq(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}
		public bool Equals(EdI<T> x, EdI<T> y)
		{
			return _eq.Equals(x.processed, y.processed);

			//throw new NotImplementedException();
		}

		public int GetHashCode(EdI<T> obj)
		{
			return _eq.GetHashCode(obj.processed);

			//throw new NotImplementedException();
		}
	}
}
