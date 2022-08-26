using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op._ed_;
using nilnul.obj;

namespace nilnul.obj.converted
{

	public class Eq<T>
		: IEqualityComparer<_converted_.ResultI<T>>
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
		public bool Equals(_converted_.ResultI<T> x, _converted_.ResultI<T> y)
		{
			return _eq.Equals(x.result, y.result);

			//throw new NotImplementedException();
		}

		public int GetHashCode(_converted_.ResultI<T> obj)
		{
			return _eq.GetHashCode(obj.result);

			//throw new NotImplementedException();
		}
	}
}
